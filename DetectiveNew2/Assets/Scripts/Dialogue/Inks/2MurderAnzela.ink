INCLUDE globals.ink
{agreementShare == 1: ->Main.Path1 | ->Main.Path2 }
===Main===
=Path1
У меня есть новости: я застал Вилсона Дупера мёртвым в одной из частей сада. Его зарезали после неудачной попытки отравления.  #speaker:Саймон #portrait:0
Мой приятель, с которым я отдыхаю в этом месте, обнаружил, что первого пострадавшего отравили синильной кислотой.
Это же цианид - вы должны были почувствовать запах горького миндаля.  #portrait:1 #speaker:Анжела
Дело в том, что окно в комнате было на распашку и поэтому все запахи просто выветрились.    #speaker:Саймон #portrait:0
С открытым окном слишком много теорий можно построить. Понять бы к какой из них стоит присматриваться. #portrait:1 #speaker:Анжела
*Следуя протоколу мне стоит задать вам пару вопросов.   #speaker:Саймон #portrait:0
->Path3
=Path2
Ну привет. Что-то хотел? #portrait:1 #speaker:Анжела
*Снова здраствуй. Удели мне пару минут твоего времени.  #speaker:Саймон #portrait:0
*Ответь на вопросы.  #speaker:Саймон #portrait:0
-Опять что-то о чём не можете говорить? Ладно, даже не отвечайте на вопрос. Что вы хотели? #portrait:1 #speaker:Анжела
->Path3
=Path3
{agreementShare != 1:
*У вас случайно не найдётся какого-нибудь ножа или ножниц?  #speaker:Саймон #portrait:0
Есть, но только маникюрные. Могу принести если надо. #portrait:1 #speaker:Анжела
**Не стоит.  #speaker:Саймон #portrait:0
->Path3
}
*Где вы были в течении этого дня?  #speaker:Саймон #portrait:0
Фотографировала. Я же репортёр, а фото - это моё хобби. #portrait:1 #speaker:Анжела
Это хорошие новости: на цифровой камере можно посмотреть дату сделанных снимков и этим самым вы обеспечили себя алиби и сократили список подозреваемых.
Если бы всё было так просто. Я пользуюсь фотоаппаратом мгновенной печати.
{agreementShare != 1: ->Path3}
Может взгляните на снимки и посмотрите нету там чего-нибудь, что могло бы помочь вашему расследованию? Наверное они могут всё-таки обеспечить мне алиби.
**Позже.  #speaker:Саймон #portrait:0
В таком случае я подготовлю все фотографии, а вы можете зайти ко мне завтра и просмотреть их.#portrait:1 #speaker:Анжела
->Path3
**Хорошо.  #speaker:Саймон #portrait:0
В таком случае я подготовлю все фотографии, а вы можете зайти ко мне завтра и просмотреть их.#portrait:1 #speaker:Анжела
->Path3
*Слышали когда-нибудь об Вилсоне Дупере?  #speaker:Саймон #portrait:0
Слышала это имя вчера за столом. Кажется, оно принадлежит действующему судье в городском суду.  #portrait:1 #speaker:Анжела
Следовательно, тот рыжеволосый мужчина - это он? Просто я не вслушивалась в разговоры и не обращала на, окружающих меня, людей внимание.
**Да, всё верно.  #speaker:Саймон #portrait:0
->Path3
**Не важно.  #speaker:Саймон #portrait:0
Понятно, я сделала из этого свои выводы. #portrait:1 #speaker:Анжела
->Path3
*Вы сталкивались сегодня с Дупером? #speaker:Саймон #portrait:0
С уверенностью могу сказать, что нет. #portrait:1 #speaker:Анжела
->Path3
+ ->Path4
=Path4
{relationshipAnzela >= 5 : 
*На этом вопросы закончились, но мне бы хотелось просто поболтать с вами.  #speaker:Саймон #portrait:0
И в чём дело? #portrait:1 #speaker:Анжела
**Вы очень интересная личность.  #speaker:Саймон #portrait:0
~relationshipAnzela = relationshipAnzela + 2
Спасибо, приятный комплимент. #portrait:1 #speaker:Анжела
->Path5
**Вы безумно красивы.  #speaker:Саймон #portrait:0
~relationshipAnzela = relationshipAnzela + 1
Что ж, мистер Винчер, вы не первый человек, который говорит мне это. #portrait:1 #speaker:Анжела
->Path5
**Думаю, что всё-таки на этом вопросы закончились. #speaker:Саймон #portrait:0
->END
}
*Спасибо за помощь. Не буду отвлекать.   #speaker:Саймон #portrait:0
->END
=Path5
В отместку скажу, что мне приятно вести с вами беседы. #portrait:1 #speaker:Анжела
*Если не возражаете, то я бы хотел познакомится с вами поближе.  #speaker:Саймон #portrait:0
~relationshipAnzela = relationshipAnzela + 1
И что же именно вас интересует? #portrait:1 #speaker:Анжела
->Path6
*Я пойду.  #speaker:Саймон #portrait:0
->END
=Path6
*Я пойду.  #speaker:Саймон #portrait:0
->END
*Какому жанру музыки ты отдаёшь предпочтение?  #speaker:Саймон #portrait:0
Может по мне и не скажешь, но я люблю фонк. #portrait:1 #speaker:Анжела
->Path6
*У тебя есть спутник жизни?  #speaker:Саймон #portrait:0
Нет. #portrait:1 #speaker:Анжела
->Path6
*Может тебе будет интересно узнать что-нибудь обо мне?  #speaker:Саймон #portrait:0
->Path9
*Любимый цвет?  #speaker:Саймон #portrait:0
Могу сразу назвать, а так же могу дать шанс угадать. #portrait:1 #speaker:Анжела
**Не хочу гадать.  #speaker:Саймон #portrait:0
->Path7
**Давай попробую догадаться.  #speaker:Саймон #portrait:0
Так и знала, что ты выберешь этот вариант: всё таки детектив, а такие люди просто не мог жить без загадок. #portrait:1 #speaker:Анжела
->Path8
=Path7
Дело твоё. Мой любимый - фиолетовый. #portrait:1 #speaker:Анжела
Для меня он выступает символом, чего-то далёкого, таинственного и прекрасного.
->Path6
=Path8
*Красный.  #speaker:Саймон #portrait:0
Это из-за моей юбки? Мимо. #portrait:1 #speaker:Анжела
Cдаёшься? 
**Нет.  #speaker:Саймон #portrait:0
-> Path8
**Да.  #speaker:Саймон #portrait:0
->Path7
*Розовый.
Ты так подумал потому что я девушка? Мимо. #portrait:1 #speaker:Анжела
Cдаёшься? 
**Нет.  #speaker:Саймон #portrait:0
-> Path8
**Да.  #speaker:Саймон #portrait:0
->Path7
*Фиолетовый.  #speaker:Саймон #portrait:0
~relationshipAnzela = relationshipAnzela + 1
Верно. Для меня он выступает символом, чего-то далёкого, таинственного и прекрасного. #portrait:1 #speaker:Анжела
->Path6
*Голубой.  #speaker:Саймон #portrait:0
Он конечно красив но нет. Cдаёшься? #portrait:1 #speaker:Анжела
**Нет.  #speaker:Саймон #portrait:0
-> Path8
**Да.  #speaker:Саймон #portrait:0
->Path7
=Path9
Да, мне бы хотелось. #portrait:1 #speaker:Анжела
У тебя есть планы на будущее?
*Не думал об этом.  #speaker:Саймон #portrait:0
*Есть.  #speaker:Саймон #portrait:0
И какие же? #portrait:1 #speaker:Анжела
**Построить дом, посадить дерево, завести собаку[...], найти прекрасную жену и вырастить пару детишек.  #speaker:Саймон #portrait:0
**Просто жить как взбредёт.[] Буду пытаться не упустить ни одного момента, данного этой жизнью.  #speaker:Саймон #portrait:0
**Состарится с тобой.  #speaker:Саймон #portrait:0
~relationshipAnzela = relationshipAnzela + 1
Над этим стоит подумать. #portrait:1 #speaker:Анжела
- ->Path10
->Path10
=Path10
Твоя любимая палитра оттенков? #portrait:1 #speaker:Анжела
*[Тёплые.] Однозначно тёплые.  #speaker:Саймон #portrait:0
~relationshipAnzela = relationshipAnzela + 1
А наши интересы чем-то схожи. #portrait:1 #speaker:Анжела
*[Холодные.] Однозначно холодные.  #speaker:Саймон #portrait:0
- ->Path6