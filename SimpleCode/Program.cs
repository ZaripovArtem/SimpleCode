using SimpleCode;

string[] A = { "unlock.microvirus.md", "visitwar.com", "visitwar.de", "fruonline.co.uk", "australia.open.com", "credit.card.us" };
string[] B = { "microvirus.md", "visitwar.de", "piratebay.co.uk", "list.stolen.credit.card.us" };
var result = Solution.solution(A, B);

foreach (var item in result)
    Console.WriteLine(item);