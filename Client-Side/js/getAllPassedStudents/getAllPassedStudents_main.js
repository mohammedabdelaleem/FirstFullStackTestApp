

document.addEventListener("DOMContentLoaded", async () => {
  const students = await getPassedStudents();
  renderStudents(students);
});
