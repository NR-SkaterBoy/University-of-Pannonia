from employee import Employee


class Manager(Employee):
	def __init__(self, name: str, projects: list[str]):
		super().__init__(name)
		self.projects = projects

	def __str__(self) -> str:
		return f"{self.name}({self.projects})"