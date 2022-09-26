<?php
$i = intval(fgets(STDIN));

switch ($i) {
  case $i == 1:
    echo "Top 1\n";
    break;
  case $i <= 3:
    echo "Top 3\n";
    break;
  case $i <= 5:
    echo "Top 5\n";
    break;
  case $i <= 10:
    echo "Top 10\n";
    break;
  case $i <= 25:
    echo "Top 25\n";
    break;
  case $i <= 50:
    echo "Top 50\n";
    break;
  case $i <= 100:
    echo "Top 100\n";
    break;
}
