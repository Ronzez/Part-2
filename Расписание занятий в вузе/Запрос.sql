Select
Prepodavatel_vuza.Familiya + ' ' + Prepodavatel_vuza.Imya + ' ' + Prepodavatel_vuza.Otchestvo AS ФИО,
Auditoriya_vuza.Nazvanie_auditorii AS Аудитория,
Disciplina.Nazvanie_disciplini AS Дисциплина,
Gruppa_vuza.Nazvanie_gruppi AS Группа,
Vremya_nachala AS [Время начала]
From Raspisanie_vuza
Join Prepodavatel_vuza on Raspisanie_vuza.id_prepodavatelya = Prepodavatel_vuza.id_prepodavatelya
Join Auditoriya_vuza on Raspisanie_vuza.id_auditorii = Auditoriya_vuza.id_auditorii
Join Disciplina on Raspisanie_vuza.id_disciplini = Disciplina.id_disciplini
Join Gruppa_vuza on Raspisanie_vuza.id_gruppi = Gruppa_vuza.id_gruppi