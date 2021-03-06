# Реализация паттерна "Цепочка обязанностей"

[![Tests](https://github.com/TimeToRave/ChainOfResponsibilityPattern/actions/workflows/dotnet.yml/badge.svg)](https://github.com/TimeToRave/ChainOfResponsibilityPattern/actions/workflows/dotnet.yml)

## Задача

Реализовать программу-парсер файлов в зависимости от их типа

Программа, реализующая алгоритм, получает на вход список файлов. И каждый попадает в обработку алгоритма.

На вход алгоритма передаётся ряд файлов, которые имеют различный тип (Xml, JSON, CSV, txt) Требуется создать цепочку обработки этих файлов, где отдельный обработчик отвечает за обработку конкретного типа документа. Обработчик логирует получение подходящего ему файла в виде "обработчик TXT получил файл filename.txt" и копирует содержимое в выходной файл.

## Диаграмма классов

![Диаграмма классов](https://raw.githubusercontent.com/TimeToRave/ChainOfResponsibilityPattern/main/ClassDiagram.png)
