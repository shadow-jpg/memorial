﻿namespace Memorial.Models
{
    public class Author
    {
            public int Id { get; set; } 
        public string Name { get; set; }
        public string Bio { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public ICollection<Poem> Poems { get; set; } = new List<Poem>();
        public Author Default => new Author 
    { 
        Id = 1, 
        Name = "Свистунов Валерий Егорович",
        Bio = "Родился я в январе – за полтора дня до крещенских морозов, но через полтора года после  Дня Победы 1945 года, в краю казаков и шахтеров, в «диком поле», на территории, где при Екатерине Второй стояла шестнадцатая царская рота. Отец – кадровый военный, воевал, брал Берлин. Мать – дочь из сельского рода. Когда отца перебрасывали вместе с воинской частью, которой он командовал, в другое место,  моя бабушка Оксана запричитала, глядя на мою мать:  «Да куда ты поедешь мыкаться одна от родных по казармам!» \\r\\n\\r\\nМатушка моя, Августа, тоже заплакала и не поехала. Так и разбежались мои родители, толком не пожив одной семьей.   А я причём? Да не причем. Отдали  меня  в большой детдом – школу-интернат. Где я и закончил одиннадцать классов.  Сполна привык к одиночеству на миру.\\r\\n\\r\\nПервая рабочая профессия – оператор бетоноукладчика на Комбинате домостроения.\\r\\n\\r\\nТам же освоил профессию  арматурщика, оператора полуавтоматов контактной сварки арматуры.\\r\\n\\r\\nПереехал в Волжский,(1966 г., лето) город-спутник Волгограда. Работал на химкомбинате – на заводе РТИ (резиновых технических изделий) оператором резиносмесителей, в самом «черном» и вредном цехе, где в воздухе – тучи сажи, аэрозоли масел мягчителей и прочая химикалия…\\r\\n\\r\\nПосле каждой смены отмывался от сажи, как и другие рабочие цеха, не менее полтора часа – не только мылом но и частично хлоркой, и теми же мягителями-маслами, которые в резиносмесителях растворяют и сажу и каучук. А под глазами все равно оставались темные от сажи тени, словно подкрашенные. Даже девушки подсмеивались - будто я подкрашиваю веки.  Вскоре стал замечать, как быстро редеет моя юная шевелюра на голове, а прическа у меня была – стандартная – под битлов и брюки клёш.  \\r\\n\\r\\nПотом работал там же электрослесарем КИП и А. Но саже это было всё равно, она летала и клубилась рядом.\\r\\n\\r\\nВ конце 1966 г. пришел случайно в литературное объединение «Поиск», созданное при редакции газеты «Волжская правда». Приняли на ура! А затем и в литературную студию при Волгоградском краевом отделении Союза писателей. Приняли – на ура! Обозвали многообещающим поэтом.\\r\\n\\r\\nИ успокоились. А потом нашлись удальцы из старых профессионалов – «забронзовевших»  заживо Волгоградских классиков, которые стали мне вредить, задерживать публикации… за прямоту моих мнений и высказываний об их партийно-декларативных произведениях.  \\r\\n\\r\\nС февраля 1967 г. – первые публикации стихов в «Волжской Правде»,  в областных газетах, коллективных сборниках, альманахах.  Выход первой книжки в «Нижне-Волжском краевом издательстве» в 1979 году. В 1980 году в августе должна была выйти моя вторая книга и свершиться прием в Союз писателей СССР, но срочный переезд в Гагарин всё перебил. Кто будет издавать книгу в Волгоградском издательстве автора, который уехал, когда, кроме него, поэтов членов Союза писателей более 60 человек, да еще снизу подпирают молодые околопрофессионалы – человек 70.\\r\\n\\r\\nЕсли издавать по десять авторов в год, то очередь рассосется  только через 13-14 лет. Это уже не смешно. А мне уже исполнилось 33 – возраст Иисуса Христа!  А что у меня в наработке? Сколько издано? Кто я – околопрофессионал с одной книжонкой? Есенина не стало в  30!\\r\\n\\r\\nСмешно, вернее – весело и замечательно, что мы, молодые волгоградские авторы, поэты 60-х, с радостью много выступали перед коллективами.\\r\\n\\r\\nТогда было время романтиков и поэтов.  Дважды выступали даже перед заключенными в зоне, на промышленной, очень вредной, химплощадке-2. Слушали зэки стихи со слезами на глазах. Мы выступили один раз, а они обратились к руководству колонии – пригласить нас снова. Ну, мы выступили еще раз.\\r\\n\\r\\nРаботал на химкомбинате, на заводе СВ (синтетического волокна)  электрослесарем КИП и А по обслуживанию огромных,- выше двух этажей,- систем кондиционирования воздуха в первом цехе, где производились синтетическое волокно, синтетический каракуль, синтетический шелк, корд и другие виды волокна. Сдуру внедрил одно рацпредложение, получил за это вознаграждение то ли 3, то ли 5 рублей. Гуляй – не хочу!\\r\\n\\r\\nРаботал на заводе ГПЗ-15 в цехе ЦКП-1 – по производству упорно-радиальных  конических подшипников  для автомобилей и тракторов разных марок на пяти одновременно станках - шлифовальных полуавтоматах.\\r\\n\\r\\nРаботал  редактором радио на химкомбинате;  корреспондентом, заведующим отделом в многотиражной газете «Знамя Труда» (чуть не написал – труба). Эта маленькая газетка мне многое дала. И коллектив был прекрасный!\\r\\n\\r\\nПерешел в Волгоградский областной комитет телевидения и радиовещания, сотрудничал с областными газетами, «Вечерним Волгоградом», Всесоюзной радиостанцией «Маяк». Принят в Союз журналистов СССР. Очерки и другие материалы публиковались в других газетах, в том числе и в «Правде».\\r\\n\\r\\nПоступил в Московский инженерно-строительный институт (ныне – университет) в 1971 году. Но не ради того, чтобы стать инженером-строителем.  Это, ладно, попутное дело, а целью было - пожить в Москве, пообщаться с поэтами молодыми и известными. И мне это удалось. Посещал встречи в ряде литературных  объединений, в том числе, которые вели Давид Самойлов, Александр  Балин, Вадим Сикорский. Встречался с писателями в трактире  ЦДЛ (Центральном доме литераторов им.Фадеева.\\r\\n\\r\\nВ одном семинаре слушал лекции о стихосложении, поэзии известных авторов, в том числе и Евгения Евтушенко. Надо было видеть и слышать его манеру общения со слушателями.\\r\\n\\r\\nОднажды, хотя и поздновато по годам, черт надоумил поступать даже в Литинститут имени Горького, но рассказ долгий  и без юмора не обойдешься.\\r\\n\\r\\nБыл дважды женат. Со второй семьей переехал с Волги в город поселкового типа  Смоленской области Гагарин, на речку Гжать, так как второй жене в Волгоградской полупустыне, где летом 42 градуса в тени, и порою выпадает в осадок слоем десять-пятнадцать сантиметров саранча.\\r\\n\\r\\nНо саранча тут ни причем, жене было не по климату, ибо она родом из северных мест, где  значительно прохладней, и легче медведя увидеть, чем незнакомого человека, но воздух чистый и климат иной. А мимо поселка с деревянными тротуарами проходит поезд один раз утром – туда, и один раз вечером – обратно. А неподалёку за железнодорожной насыпью тюремные зоны, бараки за колючей проволокой. \\r\\n\\r\\nВ самые жаркие месяцы жена в Волжском сильно болела. Слава Богу, мне и сыновьям  климат был – по барабану.\\r\\n\\r\\nПереехав в город Гагарин, а можно было и в другой, наведался в Смоленское отделение Союза писателей. Приняли неплохо секретарь Леонид Козырь и др… Но потом 13 лет откладывали мой прием в СП, хотя у меня уже было на счету 7 книг и ряд альманахов, несколько коллективных сборников всесоюзного значения. Наконец-то, приняли летом 1992 года.\\r\\n\\r\\nЧерез несколько лет, я всё проанализировал и понял, что этот злосчастный билет ничего не дает,- ибо социализм кончился, а с ним и все привилегии, в том числе и бесплатное издание книг – приносишь рукопись, если член СП, и в течение 2-3 лет книга по очереди выходит. Вышла - получай гонорар, на который можно было жить и писать новые произведения. Сдаешь снова рукопись – снова жди выхода книги.\\r\\n\\r\\nВ советское время численность членов СП СССР доходила до12-13 тысяч что-то пишущих. Но среди них были десятки достойных, талантливых  авторов. Если призадуматься – после каждого столетия остаются единицы великих или гениев, можно посчитать по пальцам одной руки! И еще небольшое окружение истинных талантов, мастеров слова.\\r\\n\\r\\nВот и живу я до сего дня в Гагарине. Пишу стихи и поэмы. И книги издаю за свой счет по мере возможности, а какие у нынешнего пенсионера возможности?  Скажу по секрету – муторное  это дело.  Но издаваться надо, даже малым тиражом. Великий Александр Сергеевич Пушкин главы своего «Онегина» издавал по отдельности в ста экземплярах и считал это нормой.\\r\\n\\r\\nЧто еще? В Гагарине работал в строительных организациях, в районных газетах  «Красное знамя» и «Гжатский вестник». Работал в областном радио в Смоленске, в отделе новостей.\\r\\n\\r\\nДа, в мутные 90-е годы работал в Москве и Подмосковье на разных стройках и в разных организациях – от  зам. генерального директора по капитальному строительству, капитальному ремонту и проектированию – до прораба, мастера, бригадира и даже простого рабочего.\\r\\n\\r\\nЕсли оглянуться назад, есть что вспомнить. Но не всегда надо. Тем более – о чем-то личном.\\r\\n\\r\\nа этом я заканчиваю свою сумбурную исповедь из жизни, а в ней было вдоволь и потешного, и горького. Но, слава Богу, жизнь моя еще не кончилась, и я ее измеряю не временем, а написанными строчками, которые удались. Постараюсь достроить свой «поэтический мир», каким его представляю. Есть поговорка: - Хочешь рассмешить Бога, расскажи ему о своих планах…-\\r\\n\\r\\nНо великий Гомер говорил: «Приятны завершенные труды».\";\r\n"
        };
}
}
