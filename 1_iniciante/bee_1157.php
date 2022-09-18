<?php
$numero = intval(fgets(STDIN));

for ($i = 1; $i <= $numero; $i++) {
  if ($numero % $i == 0) {
    echo "$i\n";
  }
}
