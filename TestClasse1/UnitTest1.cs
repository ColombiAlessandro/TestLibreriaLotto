using Lotto;
namespace TestClasse1
{
    public class UnitTest1
    {
        Lotto.Lotto lotto;
        [Fact]
        public void Test1()
        {
            lotto = new Lotto.Lotto("012", "12/11/05");
            lotto.EstraiSingolo();
            lotto.EstraiSingolo();
            int[] estrazioni = lotto.RegistroEstrazioni();
            Assert.True(estrazioni[1] != 0);

        }
        [Fact]
        public void Test2()
        {
            lotto = new Lotto.Lotto("012", "12/11/05");
            lotto.EstraiSingolo();
            int[] estrazioni = lotto.RegistroEstrazioni();
            Assert.True(estrazioni[1] == 0);

        }
        [Fact]
        public void Test3()
        {
            lotto = new Lotto.Lotto("012", "12/11/05");
            lotto.EstraiSingolo();
            lotto.EstraiSingolo();
            lotto.EstraiSingolo();
            lotto.EstraiSingolo();
            lotto.EstraiSingolo();
            Assert.Throws<Exception>(() => lotto.EstraiSingolo());

        }
        [Fact]
        public void Test4()
        {
            lotto = new Lotto.Lotto("012", "12/11/05");
            lotto.EstraiSingolo();
            lotto.EstraiSingolo();
            lotto.EstraiSingolo();
            lotto.EstraiSingolo();
            lotto.EstraiSingolo();
            lotto.Reset();
            Assert.True(lotto.RegistroEstrazioni()[0] == 0);
        }
        [Fact]
        public void Test5()
        {
            int[] prova = new int[90];
            lotto = new Lotto.Lotto("012", "12/11/05",prova,90,0);
            
            Assert.Throws<Exception>(() => lotto.EstraiSingolo());
        }
        [Fact]
        public void Test6()
        {
            int[] i = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            lotto = new Lotto.Lotto("012", "12/11/05", i, 9, 0);
            int[] j = new int[] { 1, 2, 3, 4, 5 };
            Assert.True(lotto.VerificaEstrazioni(j,5)==5);
        }
        [Fact]
        public void Test7()
        {
            int[] i = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            lotto = new Lotto.Lotto("012", "12/11/05", i, 9, 0);
            int[] j = new int[] { 1, 2, 3, 4, 5 };
            Assert.Throws<Exception>(() => lotto.VerificaEstrazioni(j,7));
        }
        [Fact]
        public void Test9()
        {
            int[] i = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            lotto = new Lotto.Lotto("012", "12/11/05", i, 9, 0);
            int[] j = new int[] { 1, 2, 3};
            Assert.Throws<Exception>(() => lotto.VerificaEstrazioni(j, 5));
        }
        [Fact]
        public void Test8()
        {
            int[] i = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            lotto = new Lotto.Lotto("012", "12/11/05", i, 9, 0);
            int[] j = new int[] { 1, 2, 3, 4, 5, 6 };
            Assert.Throws<Exception>(() => lotto.VerificaEstrazioni(j, 4));
        }
    }
}