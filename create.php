#!/usr/bin/env php

<?php

$locations = array("Pages", "Json", "ViewModels", "iOS", "Android");
$types = array("string", "uri", "int", "double", "float");
$yn = array("y", "n");

$module = array();
$module['name'] = read("Name: ");
$module['author'] = read("Author: ");
$module['version'] = read("Version: ");
$module['description'] = read("Description: ");

$module['files'] = array();
$module['options'] = array();

$matches = glob($argv[1] . '/*.cs');

foreach ($matches as $key => $value) {
    $file = file_get_contents($value);
    
    $fObj = array();
    $fObj['target'] = readChoice("Destination for ${value}?: ", $locations);
    $fObj['file'] = basename($value);
    
    if (preg_match_all("/(\\\$.*?\\\$)/", $file, $vars, PREG_PATTERN_ORDER)) {
        foreach ($vars[0] as $v) {
            $option = array();
            $option['variable'] = $v;
            $option['name'] = read("Name for ${v}?: ");
            $option['type'] = readChoice("Type for ${v}?: ", $types);
            $option['value'] = read("Default value for ${v}?: ");
            
            $module['options'][] = $option;
        }
    }
    
    $module['files'][] = $fObj;
}

$str = "# {$module['name']} v{$module['version']}

Author: {$module['author']}

## Description

{$module['description']}

## JSON

";

file_put_contents($argv[1] . '/module.json', trim(json_encode($module, JSON_PRETTY_PRINT)));
file_put_contents($argv[1] . '/README.md', $str);

echo "\n";

function read($header) {
    $t = "";
    
    do {
        echo $header;
        $t = trim(fgets(STDIN));
    } while (empty($t));
    
    return $t;
}

function readChoice($header, $arr) {
    $t = "";
    
    do {
        echo $header . "[" . implode("|", $arr) ."]: ";
        $t = trim(fgets(STDIN));
    } while (!in_array($t, $arr));
    
    return $t;
}

?>