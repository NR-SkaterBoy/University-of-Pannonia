my_list = [
    {
        "neptun": "KDLSER",
        "name": "John",
        "courses": [
            {"id": "VEMISAB132P", "points": [8, 7, 2, 4, 3]},
            {"id": "VEMISAP144A", "points": [6, 4, 8, 9, 1]},
        ],
    },
    {
        "neptun": "12LD43",
        "name": "Kevin",
        "courses": [
            {"id": "VEMISAB132P", "points": [1, 2, 5]},
            {"id": "VEMISAP144A", "points": [5, 6, 3]},
        ],
    },
    {
        "neptun": "A5DL7",
        "name": "Peter",
        "courses": [
            {"id": "VEMISAB132P", "points": [1, 9, 2, 4, 5]},
            {"id": "VEMISAP144A", "points": [7, 6, 7, 8]},
        ],
    },
]

def TaskNumber(n):
	return print(f"Task {n}:")

"""
    Adott a lenti Python lista, amely a féléves eredményeket tartalmazza. Egy Python script 
    segítségével határozd meg a VEMISAB132P kurzus során szerzett pontok átlagát!
"""
def task1():
    TaskNumber(1)
    total_points = 0
    points_count = 0
    for student in my_list:
        total_points += sum(sum(course["points"]) for course in student["courses"] if course["id"] == "VEMISAB132P")
        points_count += sum(len(course["points"]) for course in student["courses"] if course["id"] == "VEMISAB132P")
    print(f"The avarage is {total_points / points_count:.2f}")


"""
    Adott a lenti Python lista, amely a féléves eredményeket tartalmazza. Egy Python script 
    segítségével vigye fel John hiányzó három pontját a VEMISAB132P tárgyhoz, a pontok a következő 
    listában adottak: [3,4,6]
"""
def task2():
    TaskNumber(2)
    add_points = [3, 4, 6]
    for student in my_list:
        if student["name"] == "John":
            # (course["points"].extend([3, 4, 6]) for course in student["courses"] if course["id"] == "VEMISAB132P")
            for course in student["courses"]:
                if course["id"] == "VEMISAB132P":
                    course["points"].extend(add_points)
                    break
            print(f"John's points are {my_list[0]["courses"][0]["points"]}")

"""
    Adott a lenti Python lista, amely a féléves eredményeket tartalmazza. Egy Python script 
    segítségével határozza meg, hogy a VEMISAB132P kódú tárgyból ki szerezte a legtöbb pontot.
"""
def task3():
    TaskNumber(3)
    userData = {
        "name": "",
        "points": -1,
    }
    cntPoint = 0
    for student in my_list:
        for course in student["courses"]:
            if course["id"] == "VEMISAB132P":
                cntPoint = sum(course["points"])
                if userData["points"] < cntPoint:
                    userData["name"] = student["name"]
                    userData["points"] = cntPoint
    print(userData)

"""
    Adott a lenti Python lista, amely a féléves eredményeket tartalmazza. Egy Python script 
    segítségével vigye fel a listába John pontjait, amelyek VEMISAB132P esetén [1,5,2,6,4], és 
    VEMISAP144A esetén pedig [8,5,3,2,5]
"""
def task4():
    TaskNumber(4)
    for student in my_list:
        if student["name"] == "John":
            for subject in student["courses"]:
                if subject["id"] == "VEMISAB132P":
                    subject["points"] = [1, 5, 2, 6, 4]
                if subject["id"] == "VEMISAP144A":
                    subject["points"] = [8, 5, 3, 2, 5]
    print(my_list)

"""
    Adott a lenti Python lista, amely a féléves eredményeket tartalmazza. Egy Python script 
    segítségével listázza ki, hogy melyik tárgy esetén hiányzik a beírt eredmény, ha minden tárgy esetén 
    pontosan 5 kis zárthelyi dolgozat volt.
"""
def task5():
    TaskNumber(5)
    for student in my_list:
        for subject in student["courses"]:
            if len(subject["points"]) < 5:
                print(subject["id"])

task1()
task2()
task3()
task4()
task5()
