INCLUDE globals.ink
->Main
===Main===
 Слушаю. #portrait:2 #speaker:Алекс
*Уделишь мне несколько минут? #speaker:Саймон #portrait:0
Конечно.  #portrait:2 #speaker:Алекс
*Ответь  на вопросы. #speaker:Саймон #portrait:0
Хорошо.   #portrait:2 #speaker:Алекс
- ->Path1
=Path1
*Что ты знаешь о Вилсоне Дупере? #speaker:Саймон #portrait:0
Это один из постояльцев? А что такое? Он подозреваемый в деле убийства.   #portrait:2 #speaker:Алекс
**Нет. #speaker:Саймон #portrait:0
->Path1
**Нет: он теперь является частью этого дела. #speaker:Саймон #portrait:0
Вы имеете ввиду, то что его убили?   #portrait:2 #speaker:Алекс
***Да. #speaker:Саймон #portrait:0
О боже, какая кошмарная новость. Мне аж тяжело стало на сердце.   #portrait:2 #speaker:Алекс
->Path1
***Нет. #speaker:Саймон #portrait:0
->Path1
*Можете расписать ваши передвижения в течении этого дня? #speaker:Саймон #portrait:0
К сожалению, меня мало кто видел, как собственно и я остальных.   #portrait:2 #speaker:Алекс
Хах, наверное можно сказать, что моё завсегдатае место обитание - в каминной комнате, но я пробыл там только утром, а в остальное время был в этой части сада.  ->Path1
*У вас не найдётся какого-нибудь ножа или ножниц?  #speaker:Саймон #portrait:0
Почему спрашиваете? #speaker:Саймон #portrait:0
**Просто ответьте.  #speaker:Саймон #portrait:0
**Хочу отрезать нитку с одежды.  #speaker:Саймон #portrait:0
Забавно: меня уже просили помощи в похожей ситуации. #speaker:Саймон #portrait:0
**Для бумаг.[]Я рассчитывал на отдых, а не на работу и соответственно не обзавёлся такими предметами.  #speaker:Саймон #portrait:0
--У меня есть нож, но тупой - им даже бумагу не разрежешь. Он напоминает мне об брате и поэтому я не хочу его ни выкидывать, ни точить, а просто оставить всё в одном состояние. #speaker:Саймон #portrait:0
После вчерашнего инцидента я побоялся, что меня могут в чём-то заподозрить и поэтому попросил Альберта положить его в сейф.
Я не знаю где именно он находятся, но мне кажется, что за какой-то картиной. Только не говорить Энсхейну о том, что я вам рассказал о нём.
Только не подумайте, что я говорю, что вы некомпетентны... Просто ведь всякое бывает.
-- ->Path1
*Чем вы вчера отрезали ярлык у Мартин Винчера, когда помогали ему? #speaker:Саймон #portrait:0
Маникюрными ножницами, а взял я их у него. #portrait:2 #speaker:Алекс
->Path1
+ ->Path2
=Path2
*На этом всё.  #speaker:Саймон #portrait:0
*Спасибо за ответы.  #speaker:Саймон #portrait:0
- ->END