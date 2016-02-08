# SimpleSemanticTypes
A simple implementation of Semantic Types in C#. [NuGet Link](https://www.nuget.org/packages/SimpleSemanticTypes)

I've always liked the pattern of using Semantic Types, but have been deterred by the boilerplate and copy/pasting that goes along with them. This project hopes to hide all of the boilerplate code in a few base classes that anyone can inherit and extend to get the safety of semantic types but without having to implement half a dozen operator overloads for each class.

Shortly after I learned about Semantic Types, Matt Perdeck wrote a really great tutorial and associated NuGet package for Semantic Types, which you should absolutely read if you're interested in learning more about Semantic Types: http://www.codeproject.com/Articles/860646/Introducing-Semantic-Types-in-Net

My implementation will be very similar to Matt's, but with a few small changes based on my personal preferences that I think will make the adoption of Semantic Types a bit smoother.

The implementations have very high test coverage, so please take a look at the tests for some examples of how Semantic Types can be used!
