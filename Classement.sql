
insert into match values(2,9,11,'14-04-30','Montréal',2,3);

insert into FICHEMATCHJOUEUR values(1,12,1,2,2);
insert into FICHEMATCHJOUEUR values(1,13,2,1,0);
insert into FICHEMATCHJOUEUR values(1,15,0,2,0);


create view ClassementEquipe_Raw
as
--victoire Visiteur
select  2 as Point, e.NOMEQUIPE, e.NUMDIVISION
from match m inner join equipe e on e.numequipe = m.equipevisiteuse
where m.SCOREFINALER < m.SCOREFINALEV
union all
--Égalité Visiteur
select  1 as Point, e.NOMEQUIPE, e.NUMDIVISION
from match m inner join equipe e on e.numequipe = m.equipevisiteuse
where m.SCOREFINALER = m.SCOREFINALEV
union all
--Défaite Visiteur
select  0 as Point, e.NOMEQUIPE, e.NUMDIVISION
from match m inner join equipe e on e.numequipe = m.equipevisiteuse
where m.SCOREFINALER > m.SCOREFINALEV
union all 
--Victoire Receveur
select  2 as Point, e.NOMEQUIPE, e.NUMDIVISION
from match m inner join equipe e on e.numequipe = m.equipereceveuse
where m.SCOREFINALER > m.SCOREFINALEV
union all
-- Égalité Receveur
select  1 as Point, e.NOMEQUIPE, e.NUMDIVISION
from match m inner join equipe e on e.numequipe = m.equipereceveuse
where m.SCOREFINALER = m.SCOREFINALEV
union all
-- Défaite Receveur
select  0 as Point, e.NOMEQUIPE, e.NUMDIVISION
from match m inner join equipe e on e.numequipe = m.equipereceveuse
where m.SCOREFINALER < m.SCOREFINALEV
;


create view ClassementEquipe
as
select sum(Point) as Points,NOMEQUIPE,NUMDIVISION
from CLASSEMENTEQUIPE_RAW
group by NOMEQUIPE,NUMDIVISION
order by Points desc
;

-- Classement Joueurs
create view ClassementJoueur 
as
select sum(FMJ.NBBUTS*2 + FMJ.NBPASSES) as Point, J.NOM, J.PRENOM, E.NOMEQUIPE
from FICHEMATCHJOUEUR FMJ
inner join Joueurs J on FMJ.NUMJOUEUR = J.NUMJOUEUR
inner join EQUIPE E on J.NUMEQUIPE = E.NUMEQUIPE 
group by J.nom, J.PRENOM, E.NOMEQUIPE
order by point desc


;
--Classement top 3 joueur
create view Top3Joueur
as
select * from CLASSEMENTJOUEUR where rownum <=3;

commit;