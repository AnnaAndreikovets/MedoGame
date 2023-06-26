INCLUDE globals.ink
VAR LikeOrNot = 0
->Main
===Main===
Привет, Саймон. Как добрался? #speaker:Максимо #portrait:1
*  Привет, пока добирался, насмотрелся красивых пейзажей[.] - так что всё прошло гладко. #speaker:Саймон #portrait:0
~relationshipMaks = relationshipMaks + 1
-> Second
* Дорога была просто ужасна. #speaker:Саймон #portrait:0
~relationshipMaks = relationshipMaks - 1
-> Second

== Second ==
Надеюсь я хоть немного смог тебя порадовать. #speaker:Максимо #portrait:1
*Док, это самый ужасный подарок, который мне когда-либо делали. #speaker:Саймон #portrait:0
~LikeOrNot = 1
~relationshipMaks = relationshipMaks - 1
Жаль, что не смог подобрать то, что бы ты оценил. #speaker:Максимо #portrait:1
-> Third
*Ты правда смог это сделать. Спасибо за отдых. #speaker:Саймон #portrait:0
~LikeOrNot = 2
~relationshipMaks = relationshipMaks + 1
-> Third
== Third ==
В последнее время ты слишком много берёшь на себя работы. Как бы там ни было - хорошо, что ты выбрался из пещеры. #speaker:Максимо #portrait:1
*Я пойду, не буду тебя отвлекать. #speaker:Саймон #portrait:0
Не так быстро. #speaker:Максимо #portrait:1
{ LikeOrNot == 1:
Даже с тем фактом, что тебе не нравится, что из-за меня ты находишься здесь, я бы хотел попросить помочь решить головоломку. Ты просто не можешь отказать.  #speaker:Максимо #portrait:1
}
{ LikeOrNot == 2:
Если я тебя смог осчастливить, то я бы хотел, что бы ты отплатил мне какой-нибудь монетой. Предположим, ты можешь помочь решить головоломку.  #speaker:Максимо #portrait:1
}
Так вот, что бы её решить, тебе потребуется отыскать игральную доску. Как найдёшь возвращайся.
-> END