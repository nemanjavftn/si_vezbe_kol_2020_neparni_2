# si_vezbe_kol_2020_neparni_2

Тип апликације: Web– трослојна архитектура
-	Креирати базу података под називом LeagueDB и у оквиру ње направити табелу Teams са следећим колонама: Id int PK auto increment, Name nvarchar(100) NOT NULL, Couch nvarchar(50) NULL, Points int NULL. (2 бодa)
-	Креирати слој који ће вршити конекцију на базу података (Data Layer) и где ће постојати један репозиторијум за комуникацију са креираном табелом у бази података (Teams). У оквиру репозиторијума треба да постоје методе: InsertTeam (користи се за унос података у табелу Teams) и GetAllTeams (за довлачење свих тимова из базе података). Што се тиче модела, треба креирати модел-класу под називом Team са приватним пољима Id, Name, Couch, Points. (5 бодова)
-	Креирати слој у ком ће се налазити логика апликације и где ће у оквиру посебне business класе за рад са Team вертикалом постојати две методе које преко Data слоја врше унос и довлачење тимова из репозиторијума. Метода која врши довлачење тимова треба да сортира тимове према броју бодова (Points, од највећег ка најмањем). (5 бодова)
-	На крају, направити ASP.NET Web Forms апликацију и додати нову страницу/форму (и у навигацији, назив форме: teams.aspx) на којој ће се вршити унос једног тима у базу података а у доњем делу форме ће се налазити један ListBox који приказује табелу тимова (формат: <redni_broj>. <Name> <Points>. Редни број није Id тима! Током отварање странице/форме одмах се приказују тимови из базе. На сваки унос новог тима треба refresh-овати листу.  (6 бодова)
Напомене: Користити лабеле поред контрола како би форма “имала смисла”. У моделима користити приватна поља и јавна својства (или аутосвојства).
