INCLUDE globals.ink
//вы я мы ваш
->Main
===Main===
Я должен потревожить вас ещё одними плохими новостями. Сегодня был обнаружен Дупер убитым. #speaker:Саймон #portrait:0
Этот человек казался славным. Жаль, что мы не были знакомы. Хотя это даже и к лучшему.  #speaker:Альберт #portrait:2
Сто процентное убийство? Что произошло и что слышно о вчерашнем инциденте?
*Это расследование и я не смею разглашать ход его дела. #speaker:Саймон #portrait:0
Вашим нанимателем являюсь я и в итоге вы получите мои деньги. Поэтому скрытничать в данном случае просто неуместно.  #speaker:Альберт #portrait:2
**Хоть вы и мой наниматель, но расследование веду я. И мне решать, что лучше, а что нет. #speaker:Саймон #portrait:0
~relationshipAlbert = relationshipAlbert - 1
Хороший аргумент.  #speaker:Альберт #portrait:2
Не буду препятствовать расследованию. Всё таки должен сказать, что не стоит портить отношения с людьми если вы хотите добиться хорошего результата - это так, на будущее.
**Вы абсолютно правы. Его зарезали после неудачной попытки отравления.[] Мы выяснили, что первый погибший был отравлен цианидом калия. #speaker:Саймон #portrait:0
~relationshipAlbert = relationshipAlbert + 1
*Его зарезали после неудачной попытки отравления.[]Мы выяснили, что первый погибший был отравлен цианидом калия. #speaker:Саймон #portrait:0
~relationshipAlbert = relationshipAlbert + 1
Хорошая работа. Хоть какие-то успехи - это хорошо.  #speaker:Альберт #portrait:2
- ->Path1
=Path1
*Ответите на несколько вопросов? #speaker:Саймон #portrait:0
Конечно.  #speaker:Альберт #portrait:2
*Вам следуем ответить на мои следующие вопросы. #speaker:Саймон #portrait:0
~relationshipAlbert = relationshipAlbert - 1
Прозвучало как угроза. Хоть это и ваша работа, но прошу мне здесь не хамить.  #speaker:Альберт #portrait:2
- ->Path2
=Path2
*А где ваша внучка? #speaker:Саймон #portrait:0
Из-за того, что связь пропала остаётся связаться с полицией лишь двумя способами: посыльными голубями или же просто лично напрямую.  #speaker:Альберт #portrait:2
Как видите, голубятней мы не обзавелись - Кэтрин направилась в город на машине этим утром. Она хотела поехать ещё вчера, но я настоял на том, что бы сегодня.
Хоть она выглядит железной и непробиваем - это всё не так и внутри она ещё маленькое дитя. Я посчитал нужным, что бы та осмыслила случившееся и не переживала едя за рулём. ->Path3
*Что можете сказать о своём алиби на этот день? #speaker:Саймон #portrait:0
В отличии от вчерашнего дня, моё прибывание не было ограничено стенами моего кабинета. Можно сказать, что пришёл в эту комнату как раз перед тем, как вы зашли сюда.  #speaker:Альберт #portrait:2
До этого момента я прогуливался в нашей деревушке с Адамом. Он ходил на рынок за продуктами, а я составлял компанию. Можете поспрашивать людей там, что бы удостоверится в этом.
Кстати говоря, Адам ещё не вернулся : пошёл за рыбой.
->Path2
*У вас случайно не найдётся с собой ножа или ножниц? #speaker:Саймон #portrait:0
И зачем же всё это вам понадобилось?     #speaker:Альберт #portrait:2
**Хочу отрезать нитку с одежды. #speaker:Саймон #portrait:0
Похоже на ситуацию с Журтэком. Алекс мне всё рассказал. К сожалению ничего такого с собой у меня нету.   #speaker:Альберт #portrait:2
**Просто ответьте. #speaker:Саймон #portrait:0
К сожалению ничего такого с собой у меня нету.   #speaker:Альберт #portrait:2
**[Для бумаг.] Для бумаг. Я рассчитывал на отдых, а не на работу и соответственно не обзавёлся такими предметами. #speaker:Саймон #portrait:0
К сожалению ничего такого с собой у меня нету.   #speaker:Альберт #portrait:2
--->Path2
+ ->Path4
=Path3
*Так нервничать из-за незнакомца? #speaker:Саймон #portrait:0
Я уже сказал, что она выглядит железной и поэтому не уверен в её чувствах. 
Просто подозреваю, что это так: её маму убили как раз в той самой комнате, которой погиб Журтэк.  #speaker:Альберт #portrait:2
Возможно этот случай откопал, то что не стоило. Некоторые камни категорически нельзя переворачивать. ->Path3
*Когда она доберётся до ближайшего полицейского участка? #speaker:Саймон #portrait:0
Думаю, что в промежутке ужина и обеда. Ещё же надо подготовить группу, которая приедет сюда.  #speaker:Альберт #portrait:2
Если учитывать это и ещё время, которое они затратят на дорогу до этого места, то они должны приехать в течении завтрашнего дня. По-моему мнению, это будет после позднего обеда.
->Path3
+ -> Path2
=Path4
*Спасибо за представленную информацию. На этом вопросы закончились. #speaker:Саймон #portrait:0
~relationshipAlbert = relationshipAlbert + 1
*На этом вопросы закончились. #speaker:Саймон #portrait:0
- ->END