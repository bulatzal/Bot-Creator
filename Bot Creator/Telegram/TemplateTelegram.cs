using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Bot_Creator.Templates
{
    class TemplateTelegram
    {
		string code, command, answer, dialog, dialogs;
		string keyboard, keyboardSender;
		string inlineDialog, inlineDialogs, inlineCallback, inlineCallbacks, inlineCommand, inlineAnswer, button1, button2, answer1, answer2;

		public void CreateCode(string token, List<List<string>> data, string startCommand, string[] keyboardButtons, bool checkBoxKeyboardCondition, List<List<string>> inlineData)
		{
			dialogs = "";
			keyboard = "";
			keyboardSender = "";
			inlineDialogs = "";
			inlineCallbacks = "";

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
				keyboardSender = ", reply_markup = keyboard";
			}

			for (int i = 0; i < inlineData.Count; i++)
			{
				inlineCommand = LowerText(inlineData[i][0]);
				inlineAnswer = inlineData[i][1];
				if (inlineAnswer.Contains("\n"))
					inlineAnswer = ReplaceLines(inlineAnswer);
				button1 = inlineData[i][2];
				if (button1.Contains("\n"))
					button1 = ReplaceLines(button1);
				button2 = inlineData[i][3];
				if (button2.Contains("\n"))
					button2 = ReplaceLines(button2);
				answer1 = inlineData[i][4];
				if (answer1.Contains("\n"))
					answer1 = ReplaceLines(answer1);
				answer2 = inlineData[i][5];
				if (answer2.Contains("\n"))
					answer2 = ReplaceLines(answer2);

				inlineDialogs = inlineDialogs + CreateInline(command, answer, button1, button2);
				inlineCallbacks = inlineCallbacks + CreateInlineCallback(button1, button2, answer1, answer2);
			}

			code =
			"# Создано в Bot Creator\n" +
			"# Автор - Булат Заляльдинов\n" +
			"\n" +
			"import telebot\n" +
			"from telebot import types\n" +
			"\n" +
			$"token = '{token}'\n" +
			"bot = telebot.TeleBot(token)\n" +
			"\n" +
			$"{keyboard}" +
			"def sendMessage(id, text):\n" +
			$"    bot.send_message(id, text{keyboardSender})\n" +
			"\n" +
			"def sendInline(id, text, markup):\n" +
			"    bot.send_message(id, text, reply_markup = markup)\n" +
			"@bot.message_handler(content_types = ['text'])\n" +
			"def messageHandler(message):\n" +
			"    id = message.chat.id\n" +
			"    msg = message.text\n" +
			"    if msg == '/start':\n" +
			$"        sendMessage(id, '{startCommand}')\n" +
			$"{dialogs}" +
			$"{inlineDialogs}" +
			"\n" +
			"@bot.callback_query_handler(func=lambda call: True)\n" +
			"def callback_inline(call):\n" +
			"    id = call.message.chat.id\n" +
			"    msgid = call.message.message_id\n" +
			"    msg = call.message.text\n" +
			"    if call.message:\n" +
			"        if call.data == '00000000':\n" +
			"            bot.send_message(call.message.chat.id, '00000000')\n" +
			$"{inlineCallbacks}" +
			"\n" +
			$"        bot.edit_message_text(chat_id=call.message.chat.id, message_id=call.message.message_id, text=call.message.text, reply_markup=None)\n" +
			"print('Telegram бот запущен')\n" +
			"bot.polling(none_stop = True)\n";
		}

		public string CreateDialog(string command, string answer)
		{
			dialog =
			$"    elif msg == '{command}':\n" +
			$"        sendMessage(id, '{answer}')\n";

			return dialog;
		}

		public string CreateKeyboard(string[] keyboardButtons)
		{
			string buttons = "";
			for (int i = 0; i < keyboardButtons.Length; i += 4)
			{
				if (keyboardButtons[i] != null || keyboardButtons[i + 1] != null || keyboardButtons[i + 2] != null || keyboardButtons[i + 3] != null)
					buttons = buttons + $"keyboard.row({keyboardButtons[i]}{keyboardButtons[i + 1]}{keyboardButtons[i + 2]}{keyboardButtons[i + 3]})\n";

			}

			string keyboard =
			"keyboard = telebot.types.ReplyKeyboardMarkup(True)\n" +
			$"{buttons}";

			return keyboard;
		}

		public string CreateInline(string command, string answer, string button1, string button2)
		{
			inlineDialog =
			$"    elif msg == '{inlineCommand}':\n" +
			$"        keyboard = types.InlineKeyboardMarkup()\n" +
			$"        keyboard.add(types.InlineKeyboardButton(text = '{button1}', callback_data = '{button1}'))\n" +
			$"        keyboard.add(types.InlineKeyboardButton(text = '{button2}', callback_data = '{button2}'))\n" +
			$"        sendInline(id, '{inlineAnswer}', keyboard)\n";

			return inlineDialog;
		}

		public string CreateInlineCallback(string button1, string button2, string answer1, string answer2)
		{
			inlineCallback =
			$"        elif call.data == '{button1}':\n" +
			$"            bot.send_message(call.message.chat.id, '{answer1}')\n" +
			$"        elif call.data == '{button2}':\n" +
			$"            bot.send_message(call.message.chat.id, '{answer2}')\n";

			return inlineCallback;
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