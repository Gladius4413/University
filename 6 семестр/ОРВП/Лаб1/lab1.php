<?php
$a = readline("a=");
$b = 5;

$arr = array("ПРИ", "ИСТ", "ДСФ", "ВТ");

$arrX = array(1, 2, 3, 4, 5, 6, 7, 8);
$arrY = array(8, 7, 6, 5, 4, 3, 2, 1);

$array6 = array(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

$task11 = Task11($a, $b);
$task12 = Task12($a, $b, $task11);
print(" K = $task11\n");
print(" m = $task12\n");

$task21 = Task21($a, $b);
print("x = $task21\n");

$task22 = Task22($a, $b, $task21);
print("y = $task22\n");

$task23 = Task23($a, $b, $task21, $task22);
print("z = $task23\n");

$task3 = Task3($arr);
if ($task3 == true) {
    print("DSF is exist\n");
} else {
    print("DSF isn't exist\n");
}

$task4 = Task4($arrX, $arrY);
for ($i = 0; $i < count($task4); $i++) {
    print("Element №$i = $task4[$i]\n");
}

print("\n");

$task6 = Task6($array6);
for ($i = 0; $i < count($task6); $i++) {
    print("Element №$i = $task6[$i]\n");
}

function Task11($a, $b)
{
    $k = (($b - $a) ** 2) / ($b ** 2 - $a) * sin($a - $b);
    return $k;
}

function Task12($a, $b, $k)
{
    $m = ($k + sqrt(abs($a * $b))) / ($k ** 3 - $b);
    return $k;
}

function Task21($a, $b)
{
    $x = ($a + $b) * $a;
    return $x;
}

function Task22($a, $b, $x)
{
    if ($a == $b) {
        $y = $x / $a * $b;
    } else {
        $y = $x ** 2 * ($a - $b);
    }
    return $y;
}

function Task23($a, $b, $x, $y)
{
    if ($y <= 2) {
        $z = $x / $y;
    } else {
        $z = $a * $b / $x * $y;
    }
    return $z;
}

function Task3($arr)
{
    $check = false;
    foreach ($arr as $value) {
        if ($value == "ДСФ") {
            $check = true;
        }
    }
    return $check;
}

function Task4($arrX, $arrY)
{
    $arrL = array();
    for ($i = 0; $i < count($arrX); $i++) {
        $arrL[$i] = sqrt($arrX[$i] ** 2 + $arrY[$i] ** 2);
    }
    return $arrL;
}

function Task6($array)
{
    $min = min($array);
    $max = max($array);
    $newArray = array();
    for ($i = 0; $i < count($array); $i++) {
        if ($min == $array[$i]) {
            $tempMin = $i;
        } elseif ($max == $array[$i]) {
            $tempMax = $i;
        }
    }
    $array[$tempMin] = $max;
    $array[$tempMax] = $min;

    $newArray = $array;
    return $newArray;
}
