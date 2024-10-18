from employee import Employee


class Developer(Employee):
	def __init__(self, name: str, project: str, hours: list[int]):
		super().__init__(name)
		self.project = project
		self.hours = hours

	def total_hours(self) -> int:
		return sum(self.hours)
		
	def __str__(self) -> str:
		return f"{self.name}, {self.total_hours()}"