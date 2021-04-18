using Xunit;

namespace ShoppingCart
{
    public class CheckoutTests
    {
        private static int Price(string goods)
        {
            var checkout = new Checkout(new Rules());
            var goodsArray = goods.ToCharArray();
            foreach (var item in goodsArray)
            {
                checkout.Scan(item);
            }

            return checkout.Total();
        }

        [Fact]
        public void TestTotals()
        {
            Assert.Equal(0, Price(""));
            Assert.Equal(50, Price("A"));
            Assert.Equal(80, Price("AB"));
            Assert.Equal(115, Price("CBDA"));

            Assert.Equal(100, Price("AA"));
            Assert.Equal(130, Price("AAA"));
            Assert.Equal(180, Price("AAAA"));
            Assert.Equal(230, Price("AAAAA"));
            Assert.Equal(260, Price("AAAAAA"));

            Assert.Equal(160, Price("AAAB"));
            Assert.Equal(175, Price("AAABB"));
            Assert.Equal(190, Price("AAABBD"));
            Assert.Equal(190, Price("DABABA"));
        }

        [Fact]
        public void TestIncremental()
        {
            var checkout = new Checkout(new Rules());
            Assert.Equal(0, checkout.Total());

            checkout.Scan('A');
            Assert.Equal(50, checkout.Total());
            checkout.Scan('B');
            Assert.Equal(80, checkout.Total());
            checkout.Scan('B');
            Assert.Equal(130, checkout.Total());
            checkout.Scan('A');
            Assert.Equal(160, checkout.Total());
            checkout.Scan('B');
            Assert.Equal(175, checkout.Total());
        }
    }
}
