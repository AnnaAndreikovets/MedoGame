INCLUDE globals.ink
->Main
===Main===
В чём дело?  #speaker:Кетрин #portrait:0
*Хочу представится. Меня зовут Саймон Брендль и я работаю детективом. #speaker:Саймон #portrait:1
->Path1
*Если ваш дедушка не глуп, то думаю, что он уже рассказал вам обо мне.  #speaker:Саймон #portrait:1
~relationshipAlbert = relationshipAlbert - 1
->Path1
=Path1
Что ж, детектив, я хотела бы вам помочь, но боюсь, что мои знания никак не помогут вам в расследовании.  #speaker:Кетрин #portrait:0
*Это мы ещё посмотрим.  #speaker:Саймон #portrait:1
Я готова отвечать на вопросы. #speaker:Кетрин #portrait:0
->Path2
=Path2
...
*Изложите мне ваш порядок действий, в течении этого дня.  #speaker:Саймон #portrait:1
Думаю, что мне стоит начать не с приезда сюда, а с утра. Я была в городке, который ниже по склону.  #speaker:Кетрин #portrait:0 
Мисис Спринфил, которая заведует местным кафе, может подтвердить, что до 11:30 часов была у неё.
Затем прогулялась до машины, просто я свой транспорт оставила на парковке, возле дома друга мистера Хэшаига, к нему минут 5 ходьбы, села за руль и поехала сюда. 
Дальнейшие мои действия вам известны.
->Path2
*Вы знакомы с убитым?  #speaker:Саймон #portrait:1
Нет, мистера Журтэка я никогда в лицо не знавала.  #speaker:Кетрин #portrait:0
->Path2
*Видели ли вы что-то подозрительное? #speaker:Саймон #portrait:1
Нет.  #speaker:Кетрин #portrait:0
->Path2
+ ->Path3
=Path3
*Спасибо, что уделили время.  #speaker:Саймон #portrait:1
*Думаю на этом всё.  #speaker:Саймон #portrait:1
-Надеюсь, что помогла.  #speaker:Кетрин #portrait:0
->END