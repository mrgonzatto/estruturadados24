﻿using ArvoresBasicas;

/*
Tree<int> tree = new Tree<int>();
tree.Root = new Node<int>() { Data = 100 };
tree.Root.Children = 
    new List<Node<int>>{
        new Node<int>() { Data = 50, Parent = tree.Root },
        new Node<int>() { Data = 1, Parent = tree.Root },
        new Node<int>() { Data = 150, Parent = tree.Root },
    };

Console.WriteLine(
    $"Nivel teste {tree.Root.Children[0].GetHeight()}"
);

Node<int> node12 = new Node<int>() { 
    Data = 12, 
    Parent =  tree.Root.Children[0]
};
Node<int> node45 = new Node<int>() { 
    Data = 45, 
    Parent = node12 
};
Node<int> node21 = new Node<int>() { 
    Data = 21, 
    Parent = node12 
};

node12.Children!.Add(node45!);
node12.Children!.Add(node21!);

tree.Root.Children[0].Children!.Add(node12);

tree.PrintTree(tree.Root);

*/

Tree<Person> tree = new Tree<Person>();
tree.Root = new Node<Person>(){
    Data = new Person {Name = "Mauricio", Role = "CEO"},
};

tree.Root.Children = new List<Node<Person>>(){
    new Node<Person>{ 
        Data = new Person{
            Name = "John Smith", 
            Role = "Head -of Development",
        },
        Parent = tree.Root
    },
    new Node<Person>{ 
        Data = new Person{Name = "Mary Fox", Role = "Head of Research"},
        Parent = tree.Root
    },
    new Node<Person>{ 
        Data = new Person{Name = "lily Smith", Role = "Head of Sales"},
        Parent = tree.Root
    }
};


