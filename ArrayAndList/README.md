# 배열과 List\<T>
    2021.02.19(금)
---

## 1. 배열, List\<T>

    1. 배열과 List\<T>는 여러 요소를 한번에 관리 할 수 있게 해주는 데이터 구조이다.
    2. 배열은 인스턴스를 생성할 때 저장할 수 있는 요소의 개수가 정해지고 나중에 수정할 수 없다.
    3. List\<T>는 인스턴스를 생성하고 나서 요소를 추가, 삽입, 삭제 할 수 있다.
    4. 배열과 List\<T>는  IEnumerable<T> 인터페이스를 가지고 있다. 따라서 LINQ를 이용하면 List<T>역시 동일한 코드로 사용할 수 있다.


### 1.1 using 지시자

```CSharp
using System;
using System.Collection.Generics;
using System.Ling;
```


### 1.2 LINQ 사용 여부 코드 변환
```CSharp
// LINQ  사용
var numbers = Enumerable.Repeat(1, 20);
                        .ToList(); // or ToArray()

// LINQ 미사용
int[] numbers = new int[20];
for (int i = 0; i < number.Length; i++)
{
    numbers[i] = 1;
}

List<int> numbers = new List<int>();
for (int i = 0; i < number.Count; i++)
{
    numbers.Add(1);
}
```

- System.Linq 네임스페이스에 정의됀 Enumerable.Repeat 메서드를 통해 동일한 값이 반복되는 시퀀스를 만들고 이를 리스트/배열로 변환 하여 값을 채울수 있다.


```CSharp
// LINQ  사용
var array = Enumerable.Range(1,20)
                      .ToArry();

// LINQ 미사용
int[] numbers = new int[20];
for (int i = 0; i < number.Length; i++)
{
    numbers[i] = i + 1;
}

List<int> numbers = new List<int>();
for (int i = 0; i < number.Count; i++)
{
    numbers.Add(i + 1);
}
```
- Enumerable.Range() 메서드를 사용하면 연속된 숫자값을 생성할 수 있다.
- 두번째 인수에는 생성할 갯수를 지정한다.
- 테스트 코드 또는 확인을 위한 코드 작성시 유용하게 사용될 수 있다.


## 2. 컬렉션

### 2.1 LINQ 사용 여부 코드 변환

```CSharp
// LINQ 사용
// List<T> 평균 값 구하기
var number = new Lsit<int> {1,2,3,4,5,6,7,8,9};
var average = number.Average();
// 람다식
var average = Z.Avaerage(x => x.Y)

// LINQ 미사용
int sum = 0;1
foreach(int n in numbers)
{
    sum += n;
}
double average = (double)sum / number.Count;
```
- LINQ의 Average() 메서드를 이용하여 평균값을 계산할 수 있다.

### 최솟값 최댓값

```CSharp
var numbers = new List<int> { 9, 7, 3, -2, 8,0 ,1,2};
// 최솟값
var min = number.Where(n > 0)
                .Min();
// 최댓값
var maxNumber = number.Max();
```
- 최솟값은 Min(), 최댓값은 Max() 메서드를 사용한다.

### 조건 일치 요소

```CSharp
var numebr = new List<int> { 9, 45,3, 8,7,-8,-34};
// 갯수 세기
var count = number.Count(n => n == 0);
// 조건에 맞는 요소 하나이상
var exists = number.Any(n => n & 7 == 0);
// 조건에 맞는 요소가 모든요소
var isAllTrue = number.All(n => n > 0);
```
- Count 메서드는 조건이 일치하는 요소의 갯수를 셀 수 있다.
- Any 메서드는 조건이 일치하는 요소가 존재하는 여부를 알 수 있다. true or false
- All 메서드는 컬렉션의 모든 요소가 조건을 만족하는지 확인 할 수 있다.
- 일치 여부를 확인하는 경우 Count 보다 Any 메서드를 활용하자 !

