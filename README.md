# Final_test_Lunev
## Информация о проекте
Необходимо организовать систему учета для питомника в котором живут домашние и вьючные животные.

## Задание
1. Использование команды cat в Linux
   - Создать два текстовых файла: "Pets"(Домашние животные) и "Pack animals"(вьючные животные), используя команду `cat` в терминале Linux. В первом файле перечислить собак, кошек и хомяков. Во втором — лошадей, верблюдов и ослов.
   - Объединить содержимое этих двух файлов в один и просмотреть его содержимое.
   - Переименовать получившийся файл в "Human Friends"(.
Пример конечного вывода после команды “ls” :
Desktop Documents Downloads  HumanFriends.txt  Music  PackAnimals.txt  Pets.txt  Pictures  Videos

2. Работа с директориями в Linux
   - Создать новую директорию и переместить туда файл "Human Friends".
![Снимок 1 cat в Linux](https://github.com/user-attachments/assets/18c95d09-0075-4dd0-a24a-2c0ea8d910c7)

3. Работа с MySQL в Linux. “Установить MySQL на вашу вычислительную машину ”
   - Подключить дополнительный репозиторий MySQL и установить один из пакетов из этого репозитория.
![Снимок 2 mysql](https://github.com/user-attachments/assets/6a0ebc64-6540-4686-ab85-242750e0889e)
![Снимок 3 mysql](https://github.com/user-attachments/assets/a6dca181-7d95-41ad-9b9f-e73ed77d49fc)
![Снимок 4 mysql](https://github.com/user-attachments/assets/c20e6faf-8956-4e17-bd29-db2ab2f506d8)
![Снимок 5 mysql](https://github.com/user-attachments/assets/4688ad45-0072-4299-8d31-abd7a605a094)
![Снимок 6 mysql](https://github.com/user-attachments/assets/a2c2d2ba-c88d-4b1c-af97-ee08d6e7bdad)
![Снимок 7 mysql](https://github.com/user-attachments/assets/22612bba-5af5-44fa-b5b0-bd19886c1bae)

4. Управление deb-пакетами
   - Установить и затем удалить deb-пакет, используя команду `dpkg`.
![Снимок 1 управление deb-пакетами](https://github.com/user-attachments/assets/c4d3e082-39a4-4308-9f27-1ec4381f0557)
![Снимок 2 управление deb-пакетами](https://github.com/user-attachments/assets/9c344b59-9784-4914-acce-c2a10eb0cd40)
![Снимок 3 управление deb-пакетами](https://github.com/user-attachments/assets/779f6025-6405-4438-90f3-7bfd7d3dd0a4)
![Снимок 4 управление deb-пакетами](https://github.com/user-attachments/assets/2f78ba98-7d36-4f7f-b9c0-5c503b24e2b9)

5. История команд в терминале Ubuntu
   - Сохранить и выложить историю ваших терминальных команд в Ubuntu.
![history of all commands](https://github.com/user-attachments/assets/ebc8f744-4c60-4522-a90b-7abb82d5d96a)

6. Диаграмма классов:

![AnimalRegistryDiagram](https://github.com/user-attachments/assets/ff5a61be-21d0-4d96-bd21-69b8ca6017f4)

8. В подключенном MySQL репозитории создать базу данных “Друзья
человека” и создать таблицы с иерархией из диаграммы в БД:
```sql
CREATE DATABASE human_friends;

USE human_friends;

CREATE TABLE Animals (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Name VARCHAR(100),
    Type VARCHAR(50),
    BirthDate DATE
);

CREATE TABLE Commands (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    AnimalId INT,
    Command VARCHAR(100),
    FOREIGN KEY (AnimalId) REFERENCES Animals(Id)
);
```

#### Задания с 8 по 10 выполнены в ходе написания кода программы.
8. ООП и C#
 - Создать иерархию классов в C#, который будет повторять диаграмму классов созданную в задаче 6 (Диаграмма классов).
9. Программа-реестр домашних животных
        - Написать программу на Java, которая будет имитировать реестр домашних животных. 
  Должен быть реализован следующий функционал:
  9.1. Добавление нового животного
        - Реализовать функциональность для добавления новых животных в реестр.       
  Животное должно определяться в правильный класс (например, "собака", "кошка", "хомяк" и т.д.)
  9.2. Список команд животного
        - Вывести список команд, которые может выполнять добавленное животное (например, "сидеть", "лежать").
  9.3. Обучение новым командам
        - Добавить возможность обучать животных новым командам.
  9.4. Вывести список животных по дате рождения
  9.5. Навигация по меню
        - Реализовать консольный пользовательский интерфейс с меню для навигации между вышеуказанными функциями.
        
10. Счетчик животных
Создать механизм, который позволяет вывести на экран общее количество созданных животных любого типа (Как домашних, так и вьючных), то есть при создании каждого нового животного счетчик увеличивается на “1”.
