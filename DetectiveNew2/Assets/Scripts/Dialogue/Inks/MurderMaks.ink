//INCLUDE globals.ink
->Conversation
=== Conversation ===
Весёлые деньки ожидают нас. #speaker:Максимо #portrait:1
*Я уверен, что ты не мог бы быть причастен к смерти бедолаги. Но ты знаешь протокол.  #speaker:Саймон #portrait:3
*Колись, это ты убийца?  #speaker:Саймон #portrait:3
Хочешь опросить меня? Что я делал утром и так понятно, а после был в бассейне. Вышел от туда за пол часа до происшествия, тогда же переоделся и высушил волосы. С ним не знаком. #speaker:Максимо #portrait:1
- Значит уже осмотрелся. Что ты думаешь об этом? #speaker:Максимо #portrait:1
->Path1
=Path1
...
* На теле не видно побоев.  #speaker:Саймон #portrait:3
-> Path1
* Разбитая лампа и пустой стакан.  #speaker:Саймон #portrait:3
Всего скорее лампу он задел, когда противостоял смерти, значит боролся с кем-то или с приступом удушья, либо же потерял сознание. #speaker:Максимо #portrait:1
-> Path1
* А что нашёл ты?  #speaker:Саймон #portrait:3
 У трупа анемия рук и розовые кожные покровы - похоже на кислородное голодание. #speaker:Максимо #portrait:1
-> Path1
*Открытое окно.  #speaker:Саймон #portrait:3
Это наверное самая большая улика. Если он был убит, то убийца мог покинуть это помещение через окно, а так же проникнуть сюда через него. #speaker:Макс #portrait:1
Вопрос:"Почему он не закрыл его?", а так же почему оставил дверь открытой.
->Path1
+ -> Path2
=Path2
Как ты думаешь, что произошло? #speaker:Максимо #portrait:1
*Я думаю, что его отравили.  #speaker:Саймон #portrait:3
Больше всего похоже на это.  #speaker:Максимо #portrait:1
->Path3
*Я думаю, что его зарезали.  #speaker:Саймон #portrait:3
Не смешно. #speaker:Максимо #portrait:1
->Path3
*Я думаю, что произошло самоубийство.  #speaker:Саймон #portrait:3
Весьма вероятно.  #speaker:Максимо #portrait:1
->Path3
= Path3
*[Какое заключение?] И какое заключение?   #speaker:Саймон #portrait:3
На теле не видно явных повреждений, а на смерть от сердечного приступа не похоже. #speaker:Максимо #portrait:1
Думаю, что его отравили, тогда яд, который был использован, должно быть блокирует кислород крови.
Если это дело не его рук, то убийца может быть как и мужчиной, так и женщиной. Я позаимствую его кровь для пробы. 
Хорошо, что взял с собой некоторое оборудование: хотел поэкспериментировать кое с чем.
->Path3
*Что ты можешь сказать про срок давности трупа?  #speaker:Саймон #portrait:3
Если судить по тому, что я имею, то умер он совсем недавно. Может за минут 5-10 перед тем, как его обнаружили. #speaker:Максимо #portrait:1
->Path3
+ ->Path4
=Path4
*[Закончить разговор.] До скорого.  #speaker:Саймон #portrait:3
-> END