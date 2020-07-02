namespace SuperheroClash
{
    public class GameController
    {
        Player Player1;
        Player Player2;

        CardsDAO myCards;

        Deck myDeck;
        CardComparer myComparer;


        public GameController( string filePath )
        {
            myCards = new CardsDAO( filePath );
            myDeck  = new Deck( myCards.CreatingNewCards(myCards.SplittingFile() ) );
            Player1.Hand.CardsInHand = myDeck.CreatingNewHand();
            Player2.Hand.CardsInHand = myDeck.CreatingNewHand();
            Player1.HasLost = false;
            Player2.HasLost = false;

            Player1.IsActive = true; // maybe a new method to handle this?
        }

        public void GamePlay()
        {
            while ( !Player1.HasLost && !Player2.HasLost )
            {
                // get players card with stats to compare
                myComparer.Compare( ref Player1, ref Player2 );
                    // compare cards
                    // add card to player hand with greater stats... remove other player hand
                        // if equal... get more cards from players
                // check number of cards in players' hand
                if ( Player1.Hand.CardsInHand.Count == 30 )
                {
                    Player2.HasLost = true;
                }
                else if ( Player2.Hand.CardsInHand.Count == 30 )
                {
                    Player1.HasLost = true;
                }
                // assign winner and loser to correct players
            }


            
        }
    }
}