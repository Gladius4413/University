<?php
$fruitArray = array(
    "apple" => 50,
    "pear" => 60,
    "orange" => 70,
);


$fruitArray["banana"] = 80;
$fruitArray["mandarin"] = 90;


foreach ($fruitArray as $key => $price) {
    print("$key - $price\n");
}
print("\n");
$fruitArray["mango"] = 20;
$fruitArray["apricot"] = 50;


print("Массив с добавленными элементами\n");
foreach ($fruitArray as $key => $price) {
    print("$key - $price\n");
}


print("\n");
$count = 0;
$sumPrice = 0;
foreach ($fruitArray as $key => $price) {
    $count++;
    $sumPrice += $price;
}
print("Количество - $count , Цена - $sumPrice\n\n");

ksort($fruitArray);
print("Отсортированный массив:\n");
foreach ($fruitArray as $key => $price) {
    print("$key - $price\n");
}

print("\n");
$length = 5;
for ($i = 0; $i < $length; $i++) {
    for ($j = $i; $j < $length; $j++) {
        switch ($j) {
            case 0:
                print("A");
                break;
            case 1:
                print("B");
                break;
            case 2:
                print("C");
                break;
            case 3:
                print("D");
                break;
            case 4:
                print("E");
                break;
        }
    }
    print("\n");
}
