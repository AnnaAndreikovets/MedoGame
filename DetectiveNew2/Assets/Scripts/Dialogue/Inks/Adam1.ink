INCLUDE globals.ink
->Main
===Main===
->Path1(0, 0)
=Path1(relationship, conversation)
~relationshipAdam = relationshipAdam + relationship
Раз вы здесь, то можете помочь? #portrait:1 #speaker:Адам
*Конечно, какую помощь я могу вам оказать? #speaker:Саймон #portrait:8
->Path2(1)
*Извини, мне сейчас не до этого.  #speaker:Саймон #portrait:8
->Path4
=Path2(relationship)
~relationshipAdam = relationshipAdam + relationship
В подсобке, которая находиться за кухней, есть газ. Можете принести его сюда? Просто баллона, который сейчас установлен не хватит до конца дня. #portrait:1 #speaker:Адам
* Сделаю, что смогу. #speaker:Саймон #portrait:8
Рад, что вы решились мне помочь. #portrait:1 #speaker:Адам
->Path3(1, 1)
* Думаю, что  ты сам можешь сходить за ним. #speaker:Саймон #portrait:8
Не думаю: у меня куча дел на кухне. #portrait:1 #speaker:Адам
->Path4
=Path3(relationship, gas)
~relationshipAdam = relationshipAdam + relationship
Спасибо, что выслушали. Кстати, сэр, если вам что-то понадобится, то обращайтесь. Я практически всё время здесь. #portrait:1 #speaker:Адам
*[Закончить разговор.] 
До скорого. #portrait:1 #speaker:Адам
->END 
=Path4
Если вы вдруг передумаете, то мне был нужен газ, который находится в подсобке. #portrait:1 #speaker:Адам
*[Закончить разговор.] 
До скорого. #portrait:1 #speaker:Адам
->END 