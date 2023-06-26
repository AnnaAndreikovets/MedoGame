INCLUDE globals.ink
->Main
===Main===
Здраствуйте, сэр! Вы Саймон Брэндль? #speaker:Смит #portrait:1
->Path1
=Path1
* Да, а как вы узнали моё имя? #speaker:Саймон #portrait:0
Я видел статью с вами. #speaker:Смит #portrait:1
->Path3
* Да, всё верно.#speaker:Саймон #portrait:0
->Path3
*Не твоего ума дело.#speaker:Саймон #portrait:0
->Path2(-1)
=Path2(relationship)
~relationshipSmit = relationshipSmit + relationship
~conversationSmit2 = conversationSmit2 + 1
Простите, обознался.#speaker:Смит #portrait:1
*Извините, я поступил бестактно.[] Дорога вымотала, но не думаю, что этим можно оправдать мой поступок. #speaker:Саймон #portrait:0
~relationshipSmit = relationshipSmit + 1
Я понимаю и надеюсь, что вы сможете хорошо отдохнуть. #speaker:Смит #portrait:1
*Ну и сервис... #speaker:Саймон #portrait:0
~relationshipSmit = relationshipSmit - 1
... #speaker:Смит #portrait:1
- ->Path6
=Path3
~conversationSmit1 = conversationSmit1 + 1
Добро пожаловать в резиденцию Сементэль, мистер Брэндль.  Держите ключ от вашей комнаты. Она под номер 3. #speaker:Смит #portrait:1
->Path4
=Path4
*Узнать  заселился ли док.  #speaker:Саймон #portrait:0
Максимо Тенсбэк заселился недавно. У него вторая комната. #speaker:Смит #portrait:1
->Path4
*[Взять ключ.]->Path4
+ ->Path5
=Path5
...
*Спасибо за помощь.  #speaker:Саймон #portrait:0
~relationshipSmit = relationshipSmit + 1
*Я пойду. #speaker:Саймон #portrait:0
-Подождите. Я знаю, что вы всегда носите при себе оружие - мне придётся забрать его пока вы не выселитесь. #speaker:Смит #portrait:1
->END
=Path6
Теперь я точно уверен, что вы - он. Такого человека просто нельзя с кем-то спутать. #speaker:Смит #portrait:1
->Path3