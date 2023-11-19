List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numbers2 = new List<int> { 5, 6, 7, 8, 9 };

bool allGreaterThanZero = numbers.All(x => x > 0); //hepsinin koşulu sağlaması gerekir

bool anyEven = numbers.Any(x => x % 2 == 0); //en az 1 tanes sağlarsa true 

int firstElement = numbers.First(); //ilk eleman

int firstOrDefaultElement = numbers.FirstOrDefault(x => x > 10); //ilk eleman veya default

int singleElement = numbers2.Single(x => x == 6); //tek x olan elemanı seç

int singleOrDefaultElement = numbers.SingleOrDefault(x => x == 11); //tek bir elemanı seç veya default dön

double average = numbers.Average(); //ortalama alınır

var concatenatedList = numbers.Concat(numbers2); //iki liste birleştirilir

var distinctList = numbers.Distinct(); //tekrar eden elemanlar kaldırılır

var skippedList = numbers.Skip(5); // belirli sayida eleman atlanır

var takenList = numbers.Take(3); // belirli sayıda eleman  alır