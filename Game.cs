namespace Wojna
{
    class Game
    {
        public void Combat(Deck a, Deck b)//x base 0
        {
            var x = 0;
            if (a.GetCardXFromTop(x).GetValue() > b.GetCardXFromTop(x).GetValue())
            {
                for (var i = 0; i < x + 1; i++)
                {
                    a.AddCard(a.GetTopCard());
                    a.AddCard(b.GetTopCard());
                    a.RemoveTopCard();
                    b.RemoveTopCard();
                }

            }
            if (a.GetCardXFromTop(x).GetValue() < b.GetCardXFromTop(x).GetValue())
            {
                for (var i = 0; i < x + 1; i++)
                {
                    b.AddCard(a.GetTopCard());
                    b.AddCard(b.GetTopCard());
                    a.RemoveTopCard();
                    b.RemoveTopCard();
                }
            }
            if (a.GetCardXFromTop(x).GetValue() == b.GetCardXFromTop(x).GetValue())
            {
                Combat(a, b, x + 2);
            }
        }
        public void Combat(Deck a, Deck b, int x)//x base 0
        {
            if (a.GetCardXFromTop(x).GetValue() > b.GetCardXFromTop(x).GetValue())
            {
                for (var i = 0; i < x + 1; i++)
                {
                    a.AddCard(a.GetTopCard());
                    a.AddCard(b.GetTopCard());
                    a.RemoveTopCard();
                    b.RemoveTopCard();
                }
            }
            if (a.GetCardXFromTop(x).GetValue() < b.GetCardXFromTop(x).GetValue())
            {
                for (var i = 0; i < x + 1; i++)
                {
                    b.AddCard(a.GetTopCard());
                    b.AddCard(b.GetTopCard());
                    a.RemoveTopCard();
                    b.RemoveTopCard();
                }
            }
            if (a.GetCardXFromTop(x).GetValue() == b.GetCardXFromTop(x).GetValue())
            {
                Combat(a, b, x + 2);
            }
        }
    }
}
