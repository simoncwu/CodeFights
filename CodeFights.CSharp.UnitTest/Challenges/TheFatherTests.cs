using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFights.CSharp.Challenges;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges.Tests
{
    [TestClass()]
    public class TheFatherTests
    {
        [TestMethod()]
        public void theFatherTest()
        {
            var t = new TheFather();
            var haters = new[] { "Dead_Bowie Fake_Thomas_Jefferson" };
            Assert.IsTrue(t.theFather(haters));

            haters = new[] { "Dead_Bowie Fake_Thomas_Jefferson", "Fake_Thomas_Jefferson Fury_Leika", "Fury_Leika Dead_Bowie" };
            Assert.IsFalse(t.theFather(haters));

            haters = new[] { "Spider_Girl Blue_Snowman", "Blue_Snowman Roulette", "Roulette Spider_Girl" };
            Assert.IsFalse(t.theFather(haters));

            haters = new[] { "Dead_Bowie Nyssa_Raatko", "Animora Lafety_Le_Fei", "Animora Mothergod", "Animora Nyssa_Raatko", "Dead_Bowie Genevieve_Savidge", "Dead_Bowie Lafety_Le_Fei", "Animora Genevieve_Savidge", "Dead_Bowie Mothergod" };
            Assert.IsTrue(t.theFather(haters));

            haters = new[] { "Lady_Vic Abominatrix", "Harley_Quinn Trinity", "New_Wave Abominatrix", "New_Wave Trinity", "Lady_Vic Tigress", "Harley_Quinn Hypnota", "Harley_Quinn Tigress", "Hypnota Mothergod", "New_Wave Mothergod", "Hypnota Abominatrix" };
            Assert.IsFalse(t.theFather(haters));

            haters = new[] { "Lazara Coachwhip", "Lazara Silver_Swan", "Lazara Spider_Girl", "Lazara Shiv", "Lazara Syndrome", "Lazara Rad", "Lazara Margaret_Love", "Lazara Blue_Snowman" };
            Assert.IsTrue(t.theFather(haters));

            haters = new[] { "Sun_Girl Golddigger", "Jewelee Golddigger", "Zaladane Deuce", "Sun_Girl Deuce", "Mai_Shen Golddigger", "Jewelee Lazara", "Mai_Shen Lazara", "Sun_Girl Lazara", "Zaladane Lashina", "Jewelee Lashina" };
            Assert.IsTrue(t.theFather(haters));

            haters = new[] { "Inell_Izzard Margherita_Hoehn",
                "Lashawnda_Phoenix Graciela_Gandy",
                "Annamae_Metzgar Denise_Miga",
                "Dwayne_Joplin Shanti_Roden",
                "Sharonda_Salaam Phoebe_Hardy",
                "Lorrie_Whitelow Shanti_Roden",
                "Jayne_Lafrance Nanci_Ketterer",
                "Nanci_Ketterer Lashon_Dunne",
                "Berta_Wittig Margherita_Hoehn",
                "Catarina_Bengston Olinda_Conlee",
                "Lashon_Dunne Earlean_Joynt",
                "Lesa_Barnhouse Pasty_Michael",
                "Margherita_Hoehn Jayne_Lafrance",
                "Marquitta_Meurer Dwayne_Joplin",
                "Annamae_Metzgar Lashawnda_Phoenix",
                "Maryetta_Carlino Lashawnda_Phoenix",
                "Catarina_Bengston Araceli_Wyman",
                "Charisse_Lake Dwayne_Joplin",
                "Graciela_Gandy Maryetta_Carlino",
                "Jayne_Lafrance Marquitta_Meurer",
                "Denise_Miga Margherita_Hoehn",
                "Annamae_Metzgar Maryetta_Carlino",
                "Lashawnda_Phoenix Fausto_Mazzotta",
                "Mikki_Columbus Charisse_Lake",
                "Verena_Oropeza Lorrie_Whitelow",
                "Araceli_Wyman Marquitta_Meurer",
                "Verena_Oropeza Lesa_Barnhouse",
                "Marquitta_Meurer Olinda_Conlee",
                "Charisse_Lake Berta_Wittig"
            };
            Assert.IsFalse(t.theFather(haters));

            haters = new[] {
                "Willia_Faircloth Jenee_Platero",
                "Jenee_Platero Dennis_Lukes",
                "Vanessa_Alward Colby_Leeds",
                "Retta_Hedberg Dirk_Spires",
                "Inell_Izzard Fernanda_Chappel",
                "Colby_Leeds Berta_Wittig",
                "Fernanda_Chappel Berta_Wittig",
                "Sidney_Whitlock Saundra_Cozad",
                "Lavonda_Frederickson Retta_Hedberg",
                "Jenee_Platero Christal_Pippin",
                "Dirk_Spires Retta_Hedberg",
                "Lilly_Hamp Johnathon_Arpin",
                "Saundra_Cozad Fern_Grunwald",
                "Lesa_Barnhouse Fern_Grunwald"
            };
            Assert.IsTrue(t.theFather(haters));

            haters = new[]
            {
                "Lilly_Hamp Parker_Cloud",
                "Earlean_Joynt Parker_Cloud",
                "Reda_Geesey Yuko_Hereford",
                "Masako_Clontz Olympia_Parrilla",
                "Ezekiel_Brazeau Estell_Francese",
                "Hana_Castiglione Alix_Hoots",
                "Donnette_Schreckengost Alessandra_Daub",
                "Donnette_Schreckengost Estell_Francese",
                "Isela_Roma Dallas_Petroff",
                "Olympia_Parrilla Maryam_Duca",
                "Olympia_Parrilla Armand_Caprio",
                "Isela_Roma Masako_Clontz",
                "Sharie_Knickerbocker Isela_Roma",
                "Masako_Clontz Parker_Cloud",
                "Ezekiel_Brazeau Thu_Oconnell",
                "Alessandra_Daub Olympia_Parrilla",
                "Parker_Cloud Berta_Wittig",
                "Isela_Roma Berta_Wittig",
                "Olympia_Parrilla Mireya_Dingler",
                "Maryam_Duca Isela_Roma",
                "Donnette_Schreckengost Lazaro_Garmany",
                "Burt_Manthe Chandra_Merle",
                "Lazaro_Garmany Thu_Oconnell",
                "Maryam_Duca Yuko_Hereford"
            };
            Assert.IsFalse(t.theFather(haters));

            haters = new[]
            {
                "Sari_Emberton Calandra_Lubbers",
                "Shawanna_Murch Odessa_Cracraft",
                "Deane_Mcallister Romeo_Romney",
                "Romeo_Romney Iluminada_Nicley",
                "Santina_Reetz Berta_Wittig",
                "Angelina_Prigge Mohammed_Wilmeth",
                "Romeo_Romney Angelina_Prigge",
                "Horace_Randles Inell_Izzard",
                "Chandra_Merle Angelina_Prigge",
                "Angelina_Prigge Calandra_Lubbers",
                "Crystal_Eisenhart Magan_Olmedo",
                "Deane_Mcallister Berta_Wittig",
                "Chandra_Merle Horace_Randles",
                "Calandra_Lubbers Kristeen_Sandler",
                "Ezekiel_Brazeau Romeo_Romney",
                "Jami_Seat Rebbeca_Prejean",
                "Rebbeca_Prejean Armand_Caprio",
                "Ezekiel_Brazeau Thomasena_Eldred",
                "Mohammed_Wilmeth Shawanna_Murch",
                "Deane_Mcallister Horace_Randles",
                "Angelina_Prigge Donnette_Schreckengost",
                "Odessa_Cracraft Catarina_Bengston",
                "Alix_Hoots Berta_Wittig",
                "Alix_Hoots Berta_Wittig",
                "Krysten_Rossell Romeo_Romney",
                "Ezekiel_Brazeau Romeo_Romney"
            };
            Assert.IsFalse(t.theFather(haters));
        }
    }
}