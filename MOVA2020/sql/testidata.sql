INSERT INTO toimintaalue(nimi) VALUES
("Kuopio"),
("Helsinki"),
("Turku"),
("Hämeenlinna");

INSERT INTO asiakas(postinro, etunimi, sukunimi, lahiosoite, email, puhelinnro) VALUES
("41210", "Marko", "Malli", "Mallikatu 3", "marko.malli@gmail.com","00000000"),
("94800", "Anne", "Lönni", "Ilmarinnankulma", "anne.lonni@hotmail.com","00000000"),
("99990", "Make", "Ponnet", "Testikuja", "make.ponnet@outlook.com","00000000");

INSERT INTO mokki(toimintaalue_id, postinro, mokkinimi, hinta, katuosoite, kuvaus, henkilomaara, varustelu) VALUES
(1, "70500", "Markon Mökki", 57.50, "Kallekatu 30", "Kuvaus tähän jotain", 14, "vuorikiipeilyvarusteet"),
(3, "20100", "Mallun Mökki", 87.50, "Turunkatu 5", "Kuvaus tähän jotain", 18, "vuorikiipeilyvarusteet"),
(2, "00800", "Annen Maja", 109.89, "Löörinkatu", "Kuvaus tähän jotain", 29, "vuorikiipeilyvarusteet");

INSERT INTO varaus(asiakas_id, mokki_mokki_id, varattu_pvm, vahvistus_pvm, varattu_alkupvm, varattu_loppupvm) VALUES
(1, 2, "2020-04-17 20:16:00", null, "2020-06-05 20:16:00", "2020-06-18 20:16:00"),
(3, 1, "2020-04-13 19:18:00", "2020-04-17 20:16:00", "2020-06-05 20:16:00", "2020-06-05 20:16:00");

INSERT INTO lasku(varaus_id, summa, alv) VALUES
(2, 3103.52, 744.84);