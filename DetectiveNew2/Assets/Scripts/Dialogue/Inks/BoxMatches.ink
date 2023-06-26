INCLUDE globals.ink
->Main
===Main===
Снова здраствуй, что-то хотели?  #speaker:Смит #portrait:3
*Да, не моги бы вы дать мне коробок? #speaker:Саймон #portrait:0
Думаю, что да. Но не хотелось бы отдавать за просто так. У меня есть предложение: сыграй со мной в игру. #speaker:Смит #portrait:3
Ты конечно мог бы потребовать его как плату за твою помощь, но не думаю, что это будет хорошая идея: ты получишь более ценную вещь позже.
->Path1
*Гони сюда коробок.  #speaker:Саймон #portrait:0
Зачем так грубо? Я могу дать его вам но лишь при одном условии: сыграйте со мной в игру. #speaker:Смит #portrait:3
Ты конечно мог бы потребовать его как плату за твою помощь, но не думаю, что это будет хорошая идея: ты получишь более ценную вещь позже.
~relationshipSmit = relationshipSmit - 1
->Path1
=Path1
*[Я не ребёнок и не шут - так что мой ответ - нет.]Я не ребёнок, что бы играть в игрушки, а так же не шут, что бы развлекать тебя.  #speaker:Саймон #portrait:0
~relationshipSmit = relationshipSmit - 1
Если передумаете, то возвращайтесь. #speaker:Смит #portrait:3
->END
*Звучит заманчиво и что от меня требуется?  #speaker:Саймон #portrait:0
->Path2
*Ну и что от меня требуется?  #speaker:Саймон #portrait:0
~relationshipSmit = relationshipSmit + 1
->Path2
~relationshipSmit = relationshipSmit + 1
=Path2
Тебе предстоит разгадать простые две головоломки. На столе будут лежать спички и надо передвинуть одну так, что бы получился правильный пример. #speaker:Смит #portrait:3
* Я сыграю, но только потому что иначе мне его не заполучить.  #speaker:Саймон #portrait:0
~relationshipSmit = relationshipSmit - 1
~BoxMatches = BoxMatches + 1
* Я готов, выкладывай.  #speaker:Саймон #portrait:0
~relationshipSmit = relationshipSmit + 1
~BoxMatches = BoxMatches + 1
- ->END