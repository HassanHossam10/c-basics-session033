using System.Text;

// Q01
string title1 = "clean code";
string upperTitle = title1.ToUpper();
Console.WriteLine(title1);
Console.WriteLine(upperTitle);

// Q02
string bookA = "Clean Code";
string bookB = "Clean Code";
Console.WriteLine(ReferenceEquals(bookA, bookB));

// Q03
StringBuilder sb = new StringBuilder();
sb.Append("Book List");
sb.Append(" - Updated");
Console.WriteLine(sb.ToString());

// Q04
sb.Replace("Book List", "Library");
Console.WriteLine(sb.ToString());

// Q05
string title = "Clean Code";
int pages = 464;
string sentencePlus = "Book: " + title + ", Pages: " + pages;
Console.WriteLine(sentencePlus);

// Q06
string sentenceInterp = $"Book: {title}, Pages: {pages}";
Console.WriteLine(sentenceInterp);

// Q07
string sentenceFormat = string.Format("Book: {0}, Pages: {1}", title, pages);
Console.WriteLine(sentenceFormat);

// Q08
int bookPages = 464;
if (bookPages > 300)
{
    Console.WriteLine("Long Book");
}
else
{
    Console.WriteLine("Short Book");
}

// Q09
int borrowPages = 464;
bool isAvailable = true;
if (borrowPages > 300 && isAvailable)
{
    Console.WriteLine("You can borrow this book");
}

// Q10
string switchTitle = "Refactoring";
switch (switchTitle)
{
    case "Clean Code":
        Console.WriteLine("Great choice!");
        break;
    case "Refactoring":
        Console.WriteLine("Nice pick!");
        break;
    default:
        Console.WriteLine("Never heard of it");
        break;
}

// Q11
int ternaryPages = 464;
string sizeLabel = ternaryPages > 300 ? "Long Book" : "Short Book";
Console.WriteLine(sizeLabel);

// Q12
string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
for (int i = 0; i < books.Length; i++)
{
    Console.WriteLine($"{i + 1}. {books[i]}");
}

// Q13
int index = 0;
while (index < books.Length)
{
    Console.WriteLine(books[index]);
    index++;
}

// Q14
int checkCount = 0;
do
{
    Console.WriteLine("Checking book...");
    checkCount++;
} while (checkCount < 3);

// Q15
foreach (string b in books)
{
    Console.WriteLine(b);
}

// Q16
foreach (string b in books)
{
    if (b == "Refactoring")
    {
        break;
    }
    Console.WriteLine(b);
}

// Q17
foreach (string b in books)
{
    if (b == "The Pragmatic Programmer")
    {
        continue;
    }
    Console.WriteLine(b);
}

// Q18
PrintFirstBook(books);

void PrintFirstBook(string[] booksArray)
{
    if (booksArray.Length == 0)
    {
        return;
    }
    Console.WriteLine(booksArray[0]);
}