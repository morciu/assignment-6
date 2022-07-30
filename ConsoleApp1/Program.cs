using ClassLibrary1;

// Instantiating Collection
GenericCollection<string> genericCollection = new GenericCollection<string>();

// Populating Collection
genericCollection.SetAtIndex("hello", 0);
genericCollection.SetAtIndex("hi", 1);
genericCollection.SetAtIndex("Howdy", 2);
genericCollection.SetAtIndex("Yo", 3);
genericCollection.SetAtIndex("Sup", 4);

genericCollection.PrintCollection();

// Changing item values
genericCollection.SetAtIndex("Good day", 2);
genericCollection.SetAtIndex("How's it going", 4);

genericCollection.PrintCollection();

// Swapping Items By Index
genericCollection.SwapTwoItems(2, 4);

genericCollection.PrintCollection();

// Swapping by item
genericCollection.SwapTwoItems("hi", "Yo");

genericCollection.PrintCollection();

// Swapping by index - item combination
genericCollection.SwapTwoItems(6, "Yo");

genericCollection.PrintCollection();



