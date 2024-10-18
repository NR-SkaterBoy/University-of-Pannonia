--Alap táblák létrehozása
--exec db1..sp_CreateTables

-- 12 (Listázzuk ki az személygépkocsik gyártóját, típusát, napi kölcsönzési díját (és a szállítható személyek számát)
select gyarto, tipus, ar, szemelyek from szgk

--13 (Írassa ki, hogy milyen gyártmányú gépjárművek szerepelnek az szgk táblában)
select gyarto from szgk

--14 (Távolítsuk el a fenti lista ismétlődéseit)
select DISTINCT gyarto from szgk 
select gyarto from szgk group by gyarto

--15 (Írassuk ki a gépjárművek típusait gyártmányaival együtt! Figyeljen az ismétlődésre)
select DISTINCT gyarto, tipus from szgk

--16 (Módosítsa a 12. feladat megoldását úgy, hogy a gyarto oszlop neve marka, a tipus
--oszlop neve modell legyen! (12. fel.: Listázzuk ki az személygépkocsik gyártóját, típusát, 
--napi kölcsönzési díját (ar mező) és a szállítható személyek számát)
select gyarto as marka, tipus as modell, ar, szemelyek from szgk

--17 (Az előző listát módosítsa úgy, hogy a gyártó és a típus egy mezőben szerepeljen--és ezen mező felirata legyen „személygépkocsi típusa”.--Jelezze, hogy az ár Ft-ban értendő (minden adat után, pl „5000 Ft” és az ár oszlopot nevezzük át a listában „napidíj”- ra)select gyarto + ' ' + tipus as [személygépkocsi típusa], concat(ar, ' Ft') as napidíj, szemelyek from szgk

--18 (Írassa ki az ügyfeleket születési dátumuk alapján növekvő sorrendben)
select * from ugyfel order by szuldat ASC