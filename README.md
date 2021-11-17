# Bot Creator
Программное обеспечение «Bot Creator» предназначено для создания Python чат-ботов под платформы ВКонтакте, Telegram и Discord без написания кода посредством удобного и гибкого пользовательского интерфейса. При первом запуске программы пользователя встречает главная форма, на которой можно увидеть главную панель и боковое меню, включающее в себя перечень доступных платформ для разработки чат-ботов.

![](https://i.imgur.com/IMohTgs.png "Боковое меню")

## Интерфейс программы
Раздел «Основные настройки» включает в себе одни из самых важных настроек бота, без которых он не сможет корректно работать. На основе заранее заданных команд чат-бот может общаться и отвечать на сообщения пользователей, например, в бизнесе ботов обычно используют в центрах поддержки или при выполнении стандартных операций, таких как бронирование билетов, оформление заказов или регистрации в отелях.

![](https://i.imgur.com/cLtvdg5.png "Основные настройки")

В разделе «Клавиатура» можно создать клавиатуру чат-бота, которая может отправлять текстовые сообщения, указанные на самих кнопках. При общении с ботом клавиатура показывается под полем ввода в диалоге с пользователем.

![](https://i.imgur.com/Lqsq5sV.png "Клавиатура")

Раздел «Callback-кнопки» позволяет добавить в бота клавиатуру с кнопками, которая будет работать в inline-режиме, то есть клавиатура будет привязана к сообщению вместо отправки обычной клавиатуры. 

![](https://i.imgur.com/qyIDLaX.png "Callback-кнопки")

Когда пользователь добавил все необходимые настройки, он может нажать на кнопку сохранения, при нажатии на которую программа сгенерирует код чат-бота на языке Python.

## Пример работы чат-ботов
Чат-бот для платформы ВКонтакте с использованием клавиатуры:

![](https://i.imgur.com/7vLWLlp.png "Чат-бот ВК")

Чат-бот для платформы Telegram с использованием Callback-кнопок:

![](https://i.imgur.com/E0gYWAF.png "Чат-бот Telegram")

## Код чат-ботов, созданный программой

Код чат-бота для платформы ВКонтакте:

```python
# Создано в Bot Creator
# Автор - Булат Заляльдинов
import vk_api, json
from vk_api.longpoll import VkLongPoll, VkEventType

vk_session = vk_api.VkApi(token = 'Ключ')
vk_session_api = vk_session.get_api()
longpoll = VkLongPoll(vk_session)

def sender(id, text):
	vk_session.method('messages.send', { 'user_id' : id, 'message' : text, 'random_id' : 0, 'keyboard' : keyboard})

def createButton(text, color):
	return {
		'action': {
			'type': 'text',
			'payload': "{\"button\": \"" + "1" + "\"}",
			'label': f'{text}'
		},
		'color': f'{color}'
	}

keyboard = {
	'one_time': False,
	'buttons': [
		[createButton('Кнопка 1', 'primary'),createButton('Кнопка 2', 'negative'),], 
		[createButton('Кнопка 3', 'secondary'),createButton('Кнопка 4', 'negative'),createButton('Кнопка 5', 'positive'),], 
	]
}
keyboard = json.dumps(keyboard, ensure_ascii = False).encode('utf-8')
keyboard = str(keyboard.decode('utf-8'))
print('VK бот запущен')
for event in longpoll.listen():
	if event.type == VkEventType.MESSAGE_NEW:
		if event.to_me:
			message = event.text.lower()
			id = event.user_id
			if message == 'привет':
				sender(id, 'Здравствуйте!')
```

Код чат-бота для платформы Telegram:

```python
# Создано в Bot Creator
# Автор - Булат Заляльдинов

import telebot
from telebot import types

token = 'Ключ'
bot = telebot.TeleBot(token)

def sendMessage(id, text):
    bot.send_message(id, text)

def sendInline(id, text, markup):
    bot.send_message(id, text, reply_markup = markup)
@bot.message_handler(content_types = ['text'])
def messageHandler(message):
    id = message.chat.id
    msg = message.text
    if msg == '/start':
        sendMessage(id, 'Добро пожаловать!')
    elif msg == 'команда 1':
        sendMessage(id, 'Ответ 1')
    elif msg == 'команда 2':
        keyboard = types.InlineKeyboardMarkup()
        keyboard.add(types.InlineKeyboardButton(text = 'Кнопка 1', callback_data = 'Кнопка 1'))
        keyboard.add(types.InlineKeyboardButton(text = 'Кнопка 2', callback_data = 'Кнопка 2'))
        sendInline(id, 'Выберите кнопку', keyboard)

@bot.callback_query_handler(func=lambda call: True)
def callback_inline(call):
    id = call.message.chat.id
    msgid = call.message.message_id
    msg = call.message.text
    if call.message:
        if call.data == '00000000':
            bot.send_message(call.message.chat.id, '00000000')
        elif call.data == 'Кнопка 1':
            bot.send_message(call.message.chat.id, 'Ответ на кнопку 1')
        elif call.data == 'Кнопка 2':
            bot.send_message(call.message.chat.id, 'Ответ на кнопку 2')

        bot.edit_message_text(chat_id=call.message.chat.id, message_id=call.message.message_id, text=call.message.text, reply_markup=None)
print('Telegram бот запущен')
bot.polling(none_stop = True)
```
