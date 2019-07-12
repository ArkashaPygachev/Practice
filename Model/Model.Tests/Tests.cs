using NUnit.Framework;
using System.Configuration;

namespace Model.Tests {
    [TestFixture]
    public class Tests {
        [Test]
        public void ConvertCyrillicToLatinTest() {
            string alphabetFileName = ConfigurationManager.AppSettings["AlphabetFileName"];
            Localizer localizer = new Localizer();
            bool loadedSuccessfully = localizer.LoadAlphabetFromFile(alphabetFileName);
            Assert.IsTrue(loadedSuccessfully);

            Assert.AreEqual("4", localizer.Localize("ч"));
            Assert.AreEqual("k", localizer.Localize("к"));

            string inputString = "чк";
            string localizedString = localizer.Localize(inputString);
            Assert.AreEqual(inputString.Length, localizedString.Length);

            for (int index = 0; index < localizedString.Length; index++) {
                char originalLetter = inputString[index];
                char localizedLetter = localizedString[index];
                Assert.IsTrue((int)localizedLetter <= (int)originalLetter);
                Assert.IsTrue((int)localizedLetter <= 122);
            }
        }
    }
}
