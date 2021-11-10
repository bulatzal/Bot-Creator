using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Bot_Creator.Templates
{
    class TemplateVK
    {
		string code, command, answer, dialog, dialogs;
		string keyboard, keyboardSender;
		public void CreateCode(string token, List<List<string>> data, string[] keyboardButtons, bool checkBoxKeyboardCondition)
        {
			dialogs = ""; // Переменная для хранения диалогов бота
			keyboard = ""; // Переменная для хранения функции и кнопок клавиатуры
			keyboardSender = ""; // Переменная для отправки клавиатуры в def sender


			for (int i = 0; i < data.Count; i++)
			{
				command = LowerText(data[i][0]);
				answer = data[i][1];
				if (answer.Contains("\n"))
					answer = ReplaceLines(answer);				
					
				dialogs = dialogs + CreateDialog(command, answer);
			}

			if (checkBoxKeyboardCondition == true)
            {
				keyboard = keyboard + CreateKeyboard(keyboardButtons);
				keyboardSender = ", 'keyboard' : keyboard";
			}

			code =
			"# Создано в Bot Creator\n" +
			"# Автор - Булат Заляльдинов\n" +
			"import vk_api, json\n" +
			"from vk_api.longpoll import VkLongPoll, VkEventType\n" +
			"\n" +
			$"vk_session = vk_api.VkApi(token = '{token}')\n" +
			"vk_session_api = vk_session.get_api()\n" +
			"longpoll = VkLongPoll(vk_session)\n" +
			"\n" +
			"def sender(id, text):\n" +
			$"	vk_session.method('messages.send', {{ 'user_id' : id, 'message' : text, 'random_id' : 0{keyboardSender}}})\n" +
			"\n" +
			$"{keyboard}" +
			"print('VK бот запущен')\n" +
			"for event in longpoll.listen():\n" +
			"	if event.type == VkEventType.MESSAGE_NEW:\n" +
			"		if event.to_me:\n" +
			"			message = event.text.lower()\n" +
			"			id = event.user_id\n" +
			$"{dialogs}";
		}

		public string CreateDialog(string command, string answer)
        {
			dialog =
			$"			if message == '{command}':\n" +
			$"				sender(id, '{answer}')\n";

			return dialog;
		}

		public string CreateKeyboard(string[] keyboardButtons)
        {
			string buttons = "";
			for (int i = 0; i < keyboardButtons.Length; i += 4)
            {
				if (keyboardButtons[i] != null || keyboardButtons[i + 1] != null || keyboardButtons[i + 2] != null || keyboardButtons[i + 3] != null)
					buttons = buttons + $"		[{keyboardButtons[i]}{keyboardButtons[i + 1]}{keyboardButtons[i + 2]}{keyboardButtons[i + 3]}], \n";

			}

			string keyboard =
			"def createButton(text, color):\n" +
			"	return {\n" +
			"		'action': {\n" +
			"			'type': 'text',\n" +
			"			'payload': \"{\\\"button\\\": \\\"\" + \"1\" + \"\\\"}\",\n" +
			"			'label': f'{text}'\n" +
			"		},\n" +
			"		'color': f'{color}'\n" +
			"	}\n" +
			"\n" +
			"keyboard = {\n" +
				"	'one_time': False,\n" +
				"	'buttons': [\n" +
				$"{buttons}" +
				"	]\n" +
				"}\n" +
				"keyboard = json.dumps(keyboard, ensure_ascii = False).encode('utf-8')\n" +
				"keyboard = str(keyboard.decode('utf-8'))\n";

			return keyboard;
		}

		public string ReplaceLines(string str)
        {
			return Regex.Replace(str, "\r\n", "'\n'\\n");
		}

		public string LowerText(string str)
		{
			return str.ToLower();
		}

		public void BotSave(string name)
        {
			using (StreamWriter writer = new StreamWriter(Path.Combine("C:/Users/Булат/Desktop", $"{name}.py")))
			{
				writer.WriteLine(code); ;
			}
		}
	}
}
