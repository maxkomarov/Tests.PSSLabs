﻿using System;

namespace WhitePages
{
    public static class NameGenerator
    {
        public static readonly string[] SurNames = { "Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев", "Петров", "Соколов", "Михайлов", "Новиков", "Федоров", "Морозов", "Волков", "Алексеев", "Лебедев", "Семенов", "Егоров", "Павлов", "Козлов", "Степанов", "Николаев", "Орлов", "Андреев", "Макаров", "Никитин", "Захаров", "Зайцев", "Соловьев", "Борисов", "Яковлев", "Григорьев", "Романов", "Воробьев", "Сергеев", "Кузьмин", "Фролов", "Александров", "Дмитриев", "Королев", "Гусев", "Киселев", "Ильин", "Максимов", "Поляков", "Сорокин", "Виноградов", "Ковалев", "Белов", "Медведев", "Антонов", "Тарасов", "Жуков", "Баранов", "Филиппов", "Комаров", "Давыдов", "Беляев", "Герасимов", "Богданов", "Осипов", "Сидоров", "Матвеев", "Титов", "Марков", "Миронов", "Крылов", "Куликов", "Карпов", "Власов", "Мельников", "Денисов", "Гаврилов", "Тихонов", "Казаков", "Афанасьев", "Данилов", "Савельев", "Тимофеев", "Фомин", "Чернов", "Абрамов", "Мартынов", "Ефимов", "Федотов", "Щербаков", "Назаров", "Калинин", "Исаев", "Чернышев", "Быков", "Маслов", "Родионов", "Коновалов", "Лазарев", "Воронин", "Климов", "Филатов", "Пономарев", "Голубев", "Кудрявцев", "Прохоров", "Наумов", "Потапов", "Журавлев", "Овчинников", "Трофимов", "Леонов", "Соболев", "Ермаков", "Колесников", "Гончаров", "Емельянов", "Никифоров", "Грачев", "Котов", "Гришин", "Ефремов", "Архипов", "Громов", "Кириллов", "Малышев", "Панов", "Моисеев", "Румянцев", "Акимов", "Кондратьев", "Бирюков", "Горбунов", "Анисимов", "Еремин", "Тихомиров", "Галкин", "Лукьянов", "Михеев", "Скворцов", "Юдин", "Белоусов", "Нестеров", "Симонов", "Прокофьев", "Харитонов", "Князев", "Цветков", "Левин", "Митрофанов", "Воронов", "Аксенов", "Софронов", "Мальцев", "Логинов", "Горшков", "Савин", "Краснов", "Майоров", "Демидов", "Елисеев", "Рыбаков", "Сафонов", "Плотников", "Демин", "Хохлов", "Фадеев", "Молчанов", "Игнатов", "Литвинов", "Ершов", "Ушаков", "Дементьев", "Рябов", "Мухин", "Калашников", "Леонтьев", "Лобанов", "Кузин", "Корнеев", "Евдокимов", "Бородин", "Платонов", "Некрасов", "Балашов", "Бобров", "Жданов", "Блинов", "Игнатьев", "Коротков", "Муравьев", "Крюков", "Беляков", "Богомолов", "Дроздов", "Лавров", "Зуев", "Петухов", "Ларин", "Никулин", "Серов", "Терентьев", "Зотов", "Устинов", "Фокин", "Самойлов", "Константинов", "Сахаров", "Шишкин", "Самсонов", "Черкасов", "Чистяков", "Носов", "Спиридонов", "Карасев", "Авдеев", "Воронцов", "Зверев", "Владимиров", "Селезнев", "Нечаев", "Кудряшов", "Седов", "Фирсов", "Андрианов", "Панин", "Головин", "Терехов", "Ульянов", "Шестаков", "Агеев", "Никонов", "Селиванов", "Баженов", "Гордеев", "Кожевников", "Пахомов", "Зимин", "Костин", "Широков", "Филимонов", "Ларионов", "Овсянников", "Сазонов", "Суворов", "Нефедов", "Корнилов", "Любимов", "Львов", "Горбачев", "Копылов", "Лукин", "Токарев", "Кулешов", "Шилов", "Большаков", "Панкратов", "Родин", "Шаповалов", "Покровский", "Бочаров", "Никольский", "Маркин", "Горелов", "Агафонов", "Березин", "Ермолаев", "Зубков", "Куприянов", "Трифонов", "Масленников", "Круглов", "Третьяков", "Колосов", "Рожков", "Артамонов", "Шмелев", "Лаптев", "Лапшин", "Федосеев", "Зиновьев", "Зорин", "Уткин", "Столяров", "Зубов", "Ткачев", "Дорофеев", "Антипов", "Завьялов", "Свиридов", "Золотарев", "Кулаков", "Мещеряков", "Макеев", "Дьяконов", "Гуляев", "Петровский", "Бондарев", "Поздняков", "Панфилов", "Кочетков", "Суханов", "Рыжов", "Старостин", "Калмыков", "Колесов", "Золотов", "Кравцов", "Субботин", "Шубин", "Щукин", "Лосев", "Винокуров", "Лапин", "Парфенов", "Исаков", "Голованов", "Коровин", "Розанов", "Артемов", "Козырев", "Русаков", "Алешин", "Крючков", "Булгаков", "Кошелев", "Сычев", "Синицын", "Черных", "Рогов", "Кононов", "Лаврентьев", "Евсеев", "Пименов", "Пантелеев", "Горячев", "Аникин", "Лопатин", "Рудаков", "Одинцов", "Серебряков", "Панков", "Дегтярев", "Орехов", "Царев", "Шувалов", "Кондрашов", "Горюнов", "Дубровин", "Голиков", "Курочкин", "Латышев", "Севастьянов", "Вавилов", "Ерофеев", "Сальников", "Клюев", "Носков", "Озеров", "Кольцов", "Комиссаров", "Меркулов", "Киреев", "Хомяков", "Булатов", "Ананьев", "Буров", "Шапошников", "Дружинин", "Островский", "Шевелев", "Долгов", "Суслов", "Шевцов", "Пастухов", "Рубцов", "Бычков", "Глебов", "Ильинский", "Успенский", "Дьяков", "Кочетов", "Вишневский", "Высоцкий", "Глухов", "Дубов", "Бессонов", "Ситников", "Астафьев", "Мешков", "Шаров", "Яшин", "Козловский", "Туманов", "Басов", "Корчагин", "Болдырев", "Олейников", "Чумаков", "Фомичев", "Губанов", "Дубинин", "Шульгин", "Касаткин", "Пирогов", "Семин", "Трошин", "Горохов", "Стариков", "Щеглов", "Фетисов", "Колпаков", "Чесноков", "Зыков", "Верещагин", "Минаев", "Руднев", "Троицкий", "Окулов", "Ширяев", "Малинин", "Черепанов", "Измайлов", "Алехин", "Зеленин", "Касьянов", "Пугачев", "Павловский", "Чижов", "Кондратов", "Воронков", "Капустин", "Сотников", "Демьянов", "Косарев", "Беликов", "Сухарев", "Белкин", "Беспалов", "Кулагин", "Савицкий", "Жаров", "Хромов", "Еремеев", "Карташов", "Астахов", "Русанов", "Сухов", "Вешняков", "Волошин", "Козин", "Худяков", "Жилин", "Малахов", "Сизов", "Ежов", "Толкачев", "Анохин", "Вдовин", "Бабушкин", "Усов", "Лыков", "Горлов", "Коршунов", "Маркелов", "Постников", "Черный", "Дорохов", "Свешников", "Гущин", "Калугин", "Блохин", "Сурков", "Кочергин", "Греков", "Казанцев", "Швецов", "Ермилов", "Парамонов", "Агапов", "Минин", "Корнев", "Черняев", "Гуров", "Ермолов", "Сомов", "Добрынин", "Барсуков", "Глушков", "Чеботарев", "Москвин", "Уваров", "Безруков", "Муратов", "Раков", "Снегирев", "Гладков", "Злобин", "Моргунов", "Поликарпов", "Рябинин", "Судаков", "Кукушкин", "Калачев", "Грибов", "Елизаров", "Звягинцев", "Корольков", "Федосов" };
        public static readonly string[] FemaleNames = { "Аделина", "Кристина", "Алевтина", "Ксения", "Александра", "Лада", "Алена", "Лариса", "Алеся", "Лиана", "Алина", "Лидия", "Алиса", "Лилия", "Алла", "Лолита", "Альбина", "Луиза", "Анастасия ", "Любовь", "Ангелина", "Людмила", "Анжела", "Майя", "Анжелика", "Маргарита", "Анна", "Мариам", "Антонина", "Марианна", "Арина", "Марина", "Ася", "Мария", "Валентина", "Милана", "Валерия", "Милена", "Варвара", "Надежда", "Василиса", "Наталья ", "Вера", "Нелли ", "Вероника", "Ника", "Виктория", "Нина", "Виолетта ", "Оксана", "Виталина", "Олеся", "Влада", "Ольга", "Владислава", "Полина", "Галина", "Раиса", "Дана", "Регина", "Дарина", "Рената", "Дарья", "Сабина", "Даяна", "Светлана", "Диана", "Серафима", "Дина", "Снежана", "Ева", "Софья ", "Евгения", "Таисия", "Евдокия", "Тамара", "Екатерина ", "Татьяна", "Елена", "Ульяна", "Елизавета", "Эвелина", "Жанна", "Элеонора", "Зарина", "Элина", "Злата", "Эллина", "Зоя", "Эльвира", "Илона", "Эльмира", "Инна", "Эмилия ", "Ирина", "Юлиана", "Камилла", "Юлия", "Карина", "Яна", "Кира", "Ярослава" };
        public static readonly string[] MaleNames = { "Даниил", "Данил", "Денис", "Дмитрий", "Евгений", "Егор", "Захар", "Иван", "Игорь", "Илья", "Кирилл", "Константин", "Лев", "Леонид", "Максим", "Марат", "Марк", "Матвей", "Михаил", "Никита", "Николай", "Олег", "Павел", "Петр", "Рафаил", "Ренат", "Роберт", "Родион", "Роман", "Ростислав", "Руслан", "Савелий", "Святослав", "Семен", "Сергей", "Станислав", "Степан", "Тимофей", "Тимур", "Федор", "Феликс", "Филипп", "Эдуард", "Эмиль", "Эрик", "Юрий", "Яков", "Ян", "Ярослав" };
        public static readonly string[] MaleGivenNames = { "Даниилович", "Данилович", "Денисович", "Дмитриевич", "Евгеньевич", "Егорович", "Захарович", "Иванович", "Игоревич", "Ильич", "Кириллович", "Константинович", "Львович", "Леонидович", "Максимович", "Маратович", "Маркович", "Матвеевич", "Михаилович", "Никитович", "Николаевич", "Олегович", "Павелович", "Петрович", "Рафаилович", "Ренатович", "Робертович", "Родионович", "Романович", "Ростиславович", "Русланович", "Савельевич", "Святославович", "Семенович", "Сергейович", "Станиславович", "Степанович", "Тимофеевич", "Тимурович", "Федорович", "Феликсович", "Филиппович", "Эдуардович", "Эмильевич", "Эрикович", "Юрьевич", "Яковлевич", "Янович", "Ярославович" };
        public static readonly string[] StreetNames = { "Советская ул", "Молодежная ул", "Центральная ул", "Школьная ул", "Новая ул", "Садовая ул", "Лесная ул", "Набережная ул", "Ленина ул", "Мира ул", "Октябрьская ул", "Зеленая ул", "Комсомольская ул", "Заречная ул", "Первомайская ул", "Гагарина ул", "Полевая ул", "Луговая ул", "Пионерская ул", "Кирова ул", "Юбилейная ул", "Северная ул", "Пролетарская ул", "Степная ул", "Пушкина ул", "Калинина ул", "Южная ул", "Колхозная ул", "Рабочая ул", "Солнечная ул", "Железнодорожная ул", "Восточная ул", "Заводская ул", "Чапаева ул", "Нагорная ул", "Строителей ул", "Береговая ул", "Победы ул", "Горького ул", "Кооперативная ул", "Красноармейская ул", "Совхозная ул", "Речная ул", "Школьный пер", "Спортивная ул", "Озерная ул", "Строительная ул", "Парковая ул", "Чкалова ул", "Мичурина ул", " перечень улиц России ", "Подгорная ул", "Дружбы ул", "Почтовая ул", "Партизанская ул", "Вокзальная ул", "Лермонтова ул", "Свободы ул", "Дорожная ул", "Дачная ул", "Маяковского ул", "Западная ул", "Фрунзе ул", "Дзержинского ул", "Московская ул", "Свердлова ул", "Некрасова ул", "Гоголя ул", "Красная ул", "Трудовая ул", "Шоссейная ул", "Чехова ул", "Коммунистическая ул", "Труда ул", "Комарова ул", "Матросова ул", "Островского ул", "Сосновая ул", "Клубная ул", "Куйбышева ул", "Крупской ул", "Березовая ул", "Карла Маркса ул", "Марта ул", "Больничная ул", "Садовый пер", "Интернациональная ул", "Суворова ул", "Цветочная ул", "Трактовая ул", "Ломоносова ул", "Горная ул", "Космонавтов ул", "Энергетиков ул", "Шевченко ул", "Весенняя ул", "Механизаторов ул", "Коммунальная ул", "Лесной пер", "лет Победы ул", "Майская ул", " справочник улиц России ", "Энгельса ул", "Зеленый пер", "Советский пер", "Привокзальная ул", "Таежная ул", "Транспортная ул", "Новый пер", "Овражная ул", "Октябрьский пер", "Светлая ул", "Мая ул", "Вишневая ул", "Чернышевского ул", "Урицкого ул", "Ключевая ул", "Ворошилова ул", "Тургенева ул", "Толстого ул", "Первомайский пер", "Комсомольский пер", "Пионерский пер", "Песчаная ул", "Ленинградская ул", "Профсоюзная ул", "Буденного ул", "Орджоникидзе ул", "Южный пер", "Герцена ул", "Верхняя ул", "Северный пер", "Ленинская ул", "Кирпичная ул", "Мостовая ул", "Щорса ул", "Станционная ул", "Больничный пер", "Луначарского ул", "Энтузиастов ул", "Титова ул", "Лазо ул", "Речной пер", "лет Октября ул", "Уральская ул", "Почтовый пер", "Линейная ул", "Пугачева ул", "Володарского ул", "Кутузова ул", "Восточный пер", "Фабричная ул", " рейтинг улиц России ", "Чайковского ул", "Магистральная ул", "Сибирская ул", "Молодежный пер", "Крестьянская ул", "Рабочий пер", "Мелиораторов ул", "Российская ул", "Новоселов ул", "Тихая ул", "Широкая ул", "Нижняя ул", "Белинского ул", "Тельмана ул", "Тимирязева ул", "Котовского ул", "Народная ул", "лет Октября ул", "Промышленная ул", "Кольцевая ул", "Есенина ул", "К.Маркса ул", "Дальняя ул", "лет Октября ул", "Крылова ул", "Декабристов ул", "Базарная ул", "Целинная ул", "Родниковая ул", "лет Октября ул", "Фурманова ул", "Революционная ул", "Социалистическая ул", "Солнечный пер", "Колхозный пер", "Звездная ул", "Студенческая ул", "Гайдара ул", "Мирная ул", "Терешковой ул", "Кубанская ул", "Заводской пер", "Гаражная ул", "Фестивальная ул", "Гражданская ул", "Песочная ул", "Сиреневая ул", "Ватутина ул", "Тихий пер", "Западный пер", " список улиц Москвы и Роcсии ", "Степной пер", "Сельская ул", "Кузнечная ул", "Пушкинская ул", "Спортивный пер", "Крайняя ул", "Коммунаров ул", "Гвардейская ул", "Веселая ул", "Загородная ул", "Олимпийская ул", "Центральный пер", "Луговой пер", "Кооперативный пер", "Гастелло ул", "Жданова ул", "Радищева ул", "Нефтяников ул", "Полевой пер", "Осипенко ул", "Пролетарский пер", "Приозерная ул", "Рябиновая ул", "Мирный пер", "Заозерная ул", "Нахимова ул", "Боровая ул", "Жукова ул", "Павлова ул", "Степана Разина ул", "Урожайная ул", "Попова ул", "Железнодорожный пер", "Торговая ул", "Жуковского ул", "Королева ул", "Донская ул", "Пограничная ул", "Огородная ул", "Пригородная ул", "Клубный пер", "Грибоедова ул", "Стадионная ул", "Менделеева ул", "Достоевского ул", "Репина ул", "Виноградная ул", "Циолковского ул", "Воровского ул", "Совхозный пер", " перечень улиц Москвы и Роcсии ", "Киевская ул", "Красноармейский пер", "Максима Горького ул", "Дорожный пер", "Революции ул", "Индустриальная ул", "Красногвардейская ул", "Волжская ул", "Кошевого ул", "Пархоменко ул", "Свободная ул", "Кедровая ул", "Подлесная ул", "Полярная ул", "Раздольная ул", "Карьерная ул", "Мельничная ул", "Серова ул", "Украинская ул", "Шахтерская ул", "Горный пер", "Заречный пер", "Запрудная ул", "Озерный пер", "Элеваторная ул", "Майский пер", "Театральная ул", "Добролюбова ул", "Геологическая ул", "лет Победы ул", "Болотная ул", "Красина ул", "Коминтерна ул", "Придорожная ул", "Парковый пер", "Набережный пер", "лет Победы ул", "Кленовая ул", "Дачный пер", "Строительный пер", "Разина ул", "Черняховского ул", "Юбилейный пер", "Казачья ул", "Ветеранов ул", "Малая ул", "Пирогова ул", "Льва Толстого ул", "Малый пер", "Геологов ул", " справочник улиц Москвы и Роcсии ", "Короткий пер", "Тукая ул", "Морская ул", "Волгоградская ул", "Димитрова ул", "Сосновый пер", "Средняя ул", "М.Горького ул", "Безымянная ул", "Краснофлотская ул", "Братская ул", "Розы Люксембург ул", "Светлый пер", "Тенистая ул", "Учительская ул", "Овражный пер", "Маркса ул", "Безымянный пер", "Кавказская ул", "Ушакова ул", "Короткая ул", "Деповская ул", "Амурская ул", "Сенная ул", "Поселковая ул", "Мая ул", "Березовый пер", "Юности ул", "Короленко ул", "Прудовая ул", "Шолохова ул", "Депутатская ул", "Авиационная ул", "лет ВЛКСМ ул", "Черемушки ул", "Кольцова ул", "Плеханова ул", "Аэродромная ул", "Большая ул", "Приморская ул", "Алтайская ул", "Береговой пер", "Пушкина пер", "Макаренко ул", "Глинки ул", "Партизанский пер", "Специалистов ул", "Нагорный пер", "Красный пер", "Халтурина ул", "Морозова ул", "Тополиная ул", "Ростовская ул", "Тракторная ул", "Коммуны ул", "Чапаева пер", "Мелиоративная ул", "Ольховая ул", "Славянская ул", "Красных Партизан ул", "Зои Космодемьянской ул", "Карбышева ул", "Баумана ул", "Радужная ул", "Марта ул", "Правды ул", "Маркса Карла ул", "Краснодарская ул", "Фадеева ул", "Кирова пер", "Вокзальный пер", "лет СССР ул", "Стахановская ул", "Ярославская ул", "Челюскинцев ул", "Коллективная ул", "Коммунальный пер", "Ангарская ул", "Олега Кошевого ул", "Новостройка ул", "Строителей пер", "Шмидта ул", "Кузнецова ул", "Кузнечный пер", "Локомотивная ул", "Войкова ул", "Панфилова ул", "Ягодная ул", "Кирпичный пер", "Базарный пер", "Смоленская ул", "Тепличная ул", "Калинина пер", "Карла Либкнехта ул", "Парижской Коммуны ул", "Водопроводная ул", "Республиканская ул", "Автомобилистов ул", "Космодемьянской ул", "Осенняя ул", "Гагарина пер", "Байкальская ул", "Седова ул", "Песчаный пер", "Саратовская ул", "Цветочный пер", "Казанская ул", "Блюхера ул", "Ленина пер", "Воронежская ул", "Демьяна Бедного ул", "Брянская ул", "Веселый пер", "Производственная ул", "Трудовой пер", "Спартака ул", "Ленина пл", "Техническая ул", "Енисейская ул", "Николаева ул", "Мостовой пер", "Дальний пер", "Бабушкина ул", "Севастопольская ул", "Торговый пер", "Мира пер", "Окружная ул", "Октября ул", "Щетинкина ул", "Орловская ул", "Хуторская ул", "Тупиковая ул", "Каштановая ул", "Мельничный пер", "Омская ул", "Гончарова ул", "Привольная ул", "Щербакова ул", "Курортная ул", "Ивановская ул", "Выгонная ул", "Крымская ул", "Вишневый пер", "Путейская ул", "Азина ул", "Проезжая ул", "Сурикова ул", "Краснознаменная ул", "Одесская ул", "Января ул", "Подстанция ул", "Логовая ул", "Высокая ул", "Транспортный пер", "Ясная ул", "Портовая ул", "Снежная ул", "Санаторная ул", "Союзная ул", "Московский пер", "Волкова ул", "Ульяновская ул", "Лермонтова пер", "Никитина ул", "Сахалинская ул", "Горняцкая ул", "Рылеева ул", "Прибрежная ул", "Химиков ул", "Горького пер", "Рыбацкая ул", "Полтавская ул", "Тамбовская ул", "Красноярская ул", "Новосельская ул", "Некрасова пер", "Проточная ул", "Черноморская ул", "Чехова пер", "Курчатова ул", "Минская ул", "Микрорайон ул", "Маяковского пер", "Главная ул", "Фабричный пер", "Чкалова пер", "Широкий пер", "Докучаева ул", "Вольная ул", "Подгорный пер", "Просвещения ул", "Смирнова ул", "Хвойная ул", "Космическая ул", "Моховая ул", "Макарова ул", "Курская ул", "Курганная ул", "Угловая ул", "Инженерная ул", "Лесозаводская ул", "Астраханская ул", "Иванова ул", "Л.Толстого ул", "Гафури ул", "Высоцкого ул", "Дружбы пер", "Белорусская ул", "Бажова ул", "Кочубея ул", "Заовражная ул", "Азовская ул", "Весенний пер", "Ручейная ул", "Тупиковый пер", "Шоссейный пер", "Леонова ул", "Волочаевская ул", "Надежды ул", "Ставропольская ул", "Металлистов ул", "Ленина пр-кт", "Вавилова ул", "Слободская ул", "Ульянова ул", "Средний пер", "Тульская ул", "Харьковская ул", "Гоголя пер", "Петровская ул", "Павлика Морозова ул", "Владимирская ул", "Семашко ул", "Высоковольтная ул", "Шаумяна ул", "Чайкиной ул", "Матросова пер", "Лазурная ул", "Ермака ул", "Дорожников ул", "Покровская ул", "Новгородская ул", "Ключевой пер", "Ленская ул", "Советской Армии ул", "Сплавная ул", "Ударная ул", "Шевченко пер", "Калужская ул", "Монтажников ул", "Крупской пер", "Победы пер", "Прудная ул", "Советская пл", "Шишкина ул", "Краснопартизанская ул", "Ореховая ул", "Таманская ул", "Иркутская ул", "Металлургов ул", "Отрадная ул", "Беляева ул", "Большевистская ул", "Свободный пер", "Троицкая ул", "Узкий пер", "Лесхозная ул", "Дружба ул", "Васильковая ул", "Серафимовича ул", "Ильича ул", "Мусы Джалиля ул", "Механическая ул", "Невского ул", "Путевая ул", "Клары Цеткин ул", "Кузнецкая ул", "Физкультурная ул", "Звездный пер", "Коммунистический пер", "Леваневского ул", "Водников ул", "Вахитова ул", "Станиславского ул", "Черемуховая ул", "Советов ул", "Флотская ул", "Угольная ул", "Линейный пер", "Восьмого Марта ул", "Пожарского ул", "Папанина ул", "Просторная ул", "Поперечная ул", "Таежный пер", "Городская ул", "Победа ул", "8-е Марта ул", "Абрикосовая ул", "Бульварная ул", "Прохладная ул", "Томская ул", "Энергетическая ул", "Литейная ул", "Ленинский пер", "Медицинская ул", "Заливная ул", "Журавлева ул", "Бригадная ул", "Свердлова пер", "Культуры ул", "Мая ул", "Минина ул", "Машиностроителей ул", "Донской пер", "Детская ул", "Островского пер", "Тюленина ул", "Фрунзе пер", "Запорожская ул", "Дальневосточная ул", "Дзержинского пер", "Громова ул", "О.Кошевого ул", "Балтийская ул", "Р.Люксембург ул", "Февральская ул", "Толбухина ул", "Лунная ул", "Дарвина ул", "З.Космодемьянской ул", "Высотная ул", "Рязанская ул", "Пушкинский пер", "Станционный пер", "Малиновая ул", "Механизаторская ул", "Мичурина пер", "Гаражный пер", "Яблоневая ул", "Красногорская ул", "Казачий пер", "Липовая ул", "Марата ул", "Горняков ул", "Переселенческая ул", "Новосибирская ул", "Рождественская ул", "Тухачевского ул", "Школьный пр", "Красная Горка ул", "Лебедева ул", "Железнодорожников ул", "Бакинская ул", "Приречная ул", "Хабаровская ул", "Тверская ул", "Малышева ул", "Айвазовского ул", "Самарская ул", "Складская ул", "Приовражная ул", "Хмельницкого ул", "Фруктовая ул", "Ключевская ул", "Кривой пер", "Мечникова ул", "Глухой пер", "Газовиков ул", "Продольная ул", "Калининградская ул", "Земляничная ул", "Авиаторов ул", "Верхний пер", "Бородина ул", "Связи ул", "Тургенева пер", "Суворова пер", "Уфимская ул", "Кольцевой пер", "Куйбышева пер", "Демократическая ул", "Желябова ул", "Дубовая ул", "Виноградный пер", "Прямая ул", "Свободы пер", "Калининская ул", "Кировская ул", "Крайний пер", "Менжинского ул", "Крестьянский пер", "Молодогвардейская ул", "Лизы Чайкиной ул", "Горького Максима ул", "Песочный пер", "Петрова ул", "Интернациональный пер", "Кравченко ул", "Маршала Жукова ул", "Лесопильная ул", "Дача ул", "Губкина ул", "Гористая ул", "Оренбургская ул", "Невская ул", "Оборонная ул", "Паровозная ул", "Артиллерийская ул", "Пржевальского ул", "Текстильщиков ул", "Спартаковская ул", "Янтарная ул", "Челюскина ул", "Костромская ул", "Кубанский пер", "Микрорайон мкр", "Никольская ул", "Новороссийская ул", "Обская ул", "Беговая ул", "Банный пер", "Свобода ул", "Уссурийская ул", "Чернышевского пер", "К.Либкнехта ул", "Иртышская ул", "Конституции ул", "Лагерная ул", "Михайловская ул", "Либкнехта ул", "Гвардейский пер", "Пензенская ул", "Саянская ул", "Спасская ул", "Уральский пер", "Текстильная ул", "Международная ул", "Донецкая ул", "Огородный пер", "Братский пер", "Футбольная ул", "Театральный пер", "Крутой пер", "Доватора ул", "Д.Бедного ул", "Пожарный пер", "Расковой ул", "Родниковый пер", "Красносельская ул", "Мичуринская ул", "Лиманная ул", "Мира пр-кт", "Возрождения ул", "Арсеньева ул", "Пятигорская ул", "Ремесленная ул", "Рощинская ул", "Урицкого пер", "Тюменская ул", "Ярославского ул", "Краснодонская ул", "Кривая ул", "Делегатская ул", "Первая ул", "Аксакова ул", "Артема ул", "Промышленный пер", "Юлаева ул", "Челябинская ул", "Левитана ул", "Ладожская ул", "Летняя ул", "Лескова ул", "Малиновского ул", "Мусоргского ул", "Крутая ул", "Еловая ул", "Животноводов ул", "Дружбы Народов ул", "Пионеров ул", "Нефтебаза ул", "Офицерская ул", "Нестерова ул", "линия", "Сибирский пер", "Связистов ул", "Стаханова ул", "Лобачевского ул", "Ломоносова пер", "Дружная ул", "Газовая ул", "Пихтовая ул", "Б.Хмельницкого ул", "Армейская ул", "Рудничная ул", "Сергея Лазо ул", "Прогонная ул", "Революции пл", "Телеграфная ул", "Кировский пер", "Институтская ул", "Каменная ул", "Можайского ул", "Милицейская ул", "Лихачева ул", "Забайкальская ул", "Переездная ул", "Ветеринарная ул", "Федорова ул", "Ямская ул", "Каменская ул", "Карьерный пер", "Знаменская ул", "Механизаторов пер", "Межевая ул", "Громовой ул", "Онежская ул", "Надречная ул", "Огарева ул", "-го Марта ул", "Багратиона ул", "Болотный пер", "Привокзальный пер", "Салавата Юлаева ул", "Торфяная ул", "Станичная ул", "Энергетиков пер", "Камчатская ул", "Гражданский пер", "Джамбула ул", "Нижний пер", "Новаторов ул", "Ботаническая ул", "Апрельская ул", "Салтыкова-Щедрина ул", "Сеченова ул", "Солдатская ул", "Танкистов ул", "Красных Зорь ул", "М.Джалиля ул", "Джалиля ул", "Володарского пер", "Березовская ул", "Андреева ул", "Аптечная ул", "Сакко и Ванцетти ул", "Цимлянская ул", "Сосновская ул", "Чапаевская ул", "Энгельса пер", "Захарова ул", "Ипподромная ул", "Ленинградский пер", "Литвинова ул", "Гранитная ул", "Грибная ул", "Дежнева ул", "Васильева ул", "Рокоссовского ул", "Промысловая ул", "Урожайный пер", "Тупой пер", "Щорса пер", "Конечная ул", "Изумрудная ул", "Маслозаводская ул", "Охотничья ул", "Низовая ул", "Перспективная ул", "Базовая ул", "Буденного пер", "Сенной пер", "Республики ул", "Читинская ул", "Котовского пер", "Карельская ул", "Кустарная ул", "МОПРА ул", "Жемчужная ул", "Островная ул", "Парниковая ул", "Победы пл", "Барнаульская ул", "Бородинская ул", "Аэропорт ул", "Александровская ул", "Рижская ул", "Рассветная ул", "Сельскохозяйственная ул", "Сельский пер", "Пристанская ул", "Сиреневый пер", "Хлебная ул", "Условная ул", "Толстого пер", "Зорге ул", "Козлова ул", "Заслонова ул", "Луначарского пер", "Курганская ул", "Мурманская ул", "Дунайская ул", "Жигулевская ул", "Егорова ул", "Добровольского ул", "Волжский пер", "Писарева ул", "Орлова ул", "Нариманова ул", "Пестеля ул", "Автомобильная ул", "Богдана Хмельницкого ул", "Большевиков ул", "Брестская ул", "Северный мкр", "Салавата ул", "Тракторный пер", "Квартальная ул", "Люксембург ул", "Кропоткина ул", "Культурная ул", "Мамина-Сибиряка ул", "Гончарная ул", "Пермская ул", "Водная ул", "Беломорская ул", "Пугачевская ул", "Садовый пр", "Стадионный пер", "Краснооктябрьская ул", "Кедровый пер", "Лесной пр", "Кузбасская ул", "Молодой Гвардии ул", "Днепровская ул", "Объездная ул", "Армавирская ул", "Верещагина ул", "Проселочная ул", "Ползунова ул", "Учебная ул", "Тукаева ул", "Филатова ул", "Стрельникова ул", "Комарова пер", "Львовская ул", "Кулибина ул", "Герцена пер", "Первого Мая ул", "Марта пер", "Интернационала ул", "Водопьянова ул", "Соловьиная ул", "Прямой пер", "Революционный пер", "Сосновый бор ул", "Целинный пер", "Элеваторный пер", "Черниговская ул", "Каспийская ул", "Известковая ул", "Киевский пер", "Ильинская ул", "Инициативная ул", "Луганская ул", "Крылова пер", "Московское ш", "Детский пер", "Покрышкина ул", "Новогодняя ул", "Обручева ул", "Аптечный пер", "Алексеева ул", "Профсоюзный пер", "Силикатная ул", "Толстого Льва ул", "Учительский пер", "Ташкентская ул", "Худайбердина ул", "Каменный пер", "Магнитогорская ул", "Кутузова пер", "Горская ул", "Загородный пер", "Вологодская ул", "Державина ул", "Бебеля ул", "Славы ул", "Русская ул", "Правобережная ул", "Пугачева пер", "Радужный пер", "Свободы пл", "Пригородный пер", "Северный пр" };

        public static FullName GetFullName(GenderEnum gender, Random rnd = null)
        {
            if (rnd == null)
                rnd = new Random();

            if (gender == GenderEnum.Male)
                return new FullName(SurNames[rnd.Next(SurNames.Length - 1)],
                                    MaleNames[rnd.Next(MaleNames.Length - 1)],
                                    MaleGivenNames[rnd.Next(MaleNames.Length - 1)],
                                    GenderEnum.Male);
            if (gender == GenderEnum.Female)
                return new FullName(SurNames[rnd.Next(SurNames.Length - 1)] + "а",
                                    FemaleNames[rnd.Next(FemaleNames.Length - 1)],
                                    MaleGivenNames[rnd.Next(MaleNames.Length - 1)].Replace("вич", "вна"),
                                    GenderEnum.Male);
            else
            {
                if (rnd.Next() % 2 == 0)
                    return new FullName(SurNames[rnd.Next(SurNames.Length - 1)],
                                   MaleNames[rnd.Next(MaleNames.Length - 1)],
                                   MaleGivenNames[rnd.Next(MaleNames.Length - 1)],
                                   GenderEnum.Male);
                else
                    return new FullName(SurNames[rnd.Next(SurNames.Length - 1)] + "а",
                                    FemaleNames[rnd.Next(MaleNames.Length - 1)],
                                    MaleGivenNames[rnd.Next(MaleNames.Length - 1)].Replace("вич", "вна"),
                                    GenderEnum.Male);
            }
        }

        public static FullName[] GetFullNames(int quantity = 10, GenderEnum gender = GenderEnum.UnknownOrAny )
        {
            Random rnd = new Random();
            FullName[] res = new FullName[quantity];
            while (quantity > 0)
            {
                res[quantity - 1] = GetFullName(gender, rnd);
                quantity--;
            }
            return res;
        }

        public static string GetStreetName(Random rnd = null)
        {
            if (rnd == null)
                rnd = new Random();
            return StreetNames[rnd.Next(StreetNames.Length)];
        }

        public enum GenderEnum
        {
            Male = 1,
            Female = 2,
            UnknownOrAny = 3
        }

        public struct FullName
        {
            public string SurName;
            public string FirstName;
            public string GivenName;
            public GenderEnum Gender;

            public FullName(string surName, string firstName, string givenName, GenderEnum gender)
            {
                SurName = surName;
                FirstName = firstName;
                GivenName = givenName;
                Gender = gender;
            }

            public override string ToString()
            {
                return (SurName + " " + FirstName + " " + GivenName + " ");
            }
        }
    }
}