using System.Collections.Generic;
using System.IO;
using System;
namespace _4KetvirtaUzduotis_MokyklosTvarkarastis
{
//Kurti mokyklos tvarkaraščio generatoriaus sistemą.Sistema turėtų leisti sukurti tvarkaraščius kelioms klasėms, atsižvelgiant į paskaitų laikus, mokytojų prieinamumą ir klasių poreikius.

//Pagrindiniai Objektai:
//Pamoka: Aprašo pavadinimą, trukmę ir dalyką.
//Mokytojas: Turi vardą, pavardę ir sąrašą dalykų, kuriuos gali dėstyti.

//Klasė: Turi unikalų identifikatorius, klasės pavadinimą ir sąrašą būtinų dalykų.

//Paveldėjimas:
//Sukurti klases DarboDiena ir Savaitė, kur DarboDiena apima pamokų sąrašą vienai dienai, o Savaitė - pamokų sąrašus visai savaitei.

//Interfeisai:
//ITvarkarastis: Turėtų metodą GeneruotiTvarkarastį, kuris priima klases ir grąžina jų tvarkaraščius.
//IPatikrinimas: Metodai ArMokytojasLaisvas ir ArPamokaGalima patikrinti, ar mokytojas yra laisvas tam tikru laiku ir ar galima priskirti pamoką tam tikrai klasei.

//Logika:
//Pamokos negali vykti tuo pačiu metu jei tas pats mokytojas turi būti skirtingose klasėse.
//Kiekviena klasė turi turėti visus reikiamus dalykus per savaitę.
//Optimaliai paskirstyti mokytojus tarp klasių pagal jų kompetencijas ir prieinamumą.

//Ciklai ir Sąlyginiai Teiginiai:
//Naudojant ciklus iteruoti per visas klases ir mokytojus, kad sudaryti tvarkaraštį.
//if sąlygos naudojamos patikrinti, ar mokytojas yra laisvas ar pamoka gali būti priskirta klasei pagal dienos ar savaitės apribojimus.
        public class UI
        {
                public static void Main(string[] args)
                {

                }
        }
}