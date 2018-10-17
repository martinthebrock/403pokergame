using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomePokerGameSln.Code {
  public class Deck {
    private List<Tuple<int,int>> cards;
    private int curCardIndex;

    /// <summary>
    /// constructs a new deck object
    /// </summary>
    public Deck() {
      newDeck();
      shuffleDeck();
    }

    /// <summary>
    /// Generates a new deck of int,int tuples
    /// </summary>
    public void newDeck() {
      // face: 0 - 12
      // suit: 0 - 3
      cards = new List<Tuple<int, int>>();
      for (int f = 0; f <= 12; f++) {
        for (int s = 0; s <= 3; s++) {
          cards.Add(new Tuple<int, int>(f, s));
        }
      }
    }

    public void shuffleDeck() {
      if (cards == null || cards.Count == 0)
        newDeck();
      Random rand = new Random(DateTime.Now.Millisecond);
      List<Tuple<int, int>> curCards = cards;
      List<Tuple<int, int>> shuffledCards = new List<Tuple<int, int>>();
      while (curCards.Count > 0) {
        int index = rand.Next(0, curCards.Count);
        shuffledCards.Add(curCards[index]);
        curCards.RemoveAt(index);
      }
      this.cards = shuffledCards;
      curCardIndex = 0;
    }

    public Tuple<int,int> nextCard() {
      if (curCardIndex >= 52 - 5) {
        shuffleDeck();
      }
      return cards[curCardIndex++];
    }
  }
}
