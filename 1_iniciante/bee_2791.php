<?php
$ent = fgets(STDIN);
$copos = explode(" ", $ent);

if ($copos[0] == "1" || $copos[1] == "1") {
  if ($copos[0] == "1") {
    echo "1\n";
  } else {
    echo "2\n";
  }
} else {
  if ($copos[2] == "1") {
    echo "3\n";
  } else {
    echo "4\n";
  }
}
