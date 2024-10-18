from manager import Manager
from developer import Developer

redmine = [
    { "project" : "GINOP-2.2.1", "role":"developer", "name" : "Jack", "hours" : [6,3,1,2,1] },
    { "project" : "TAMOP-A.2.1", "role":"developer", "name" : "Kevin", "hours" : [2,4,7,5,5] },
    { "project" : "KFI-2022/02", "role":"developer", "name" : "Robert", "hours" : [1,4,3,6,1] },
    { "projects" : ["TAMOP-A.2.1", "KFI-2022/02"], "role":"manager", "name" : "Tom" },
    { "project" : "GINOP-2.2.1", "role":"developer", "name" : "Bob", "hours" : [2,5,7,6,2] },
    { "project" : "KFI-2022/02", "role":"developer", "name" : "William", "hours" : [6,3,1,2,6] },
    { "project" : "TAMOP-A.2.1", "role":"developer", "name" : "Jack", "hours" : [1,1,3,0,6] },
    { "project" : "GINOP-2.2.1", "role":"developer", "name" : "Mark", "hours" : [6,4,1,3,3] },
    { "project" : "KFI-2022/02", "role":"developer", "name" : "Michael", "hours" : [5,4,7,6,6] },
    { "project" : "GINOP-2.2.1", "role":"developer", "name" : "Maria", "hours" : [3,2,1,2,2] },
    { "project" : "GINOP-2.2.1", "role":"developer", "name" : "Ryan", "hours" : [6,3,3,1,5] },
    { "projects" : ["GINOP-2.2.1"], "role":"manager", "name" : "Scott" }
]

employees = []

for item in redmine:
	if item["role"] == "developer":
		developer = Developer(item["name"], item["project"], item["hours"])
		employees.append(developer)
	elif item["role"] == "manager":
		manager = Manager(item["name"], item["projects"])
		employees.append(manager)

for employee in employees:
	print(employee)