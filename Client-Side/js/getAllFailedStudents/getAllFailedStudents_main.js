

document.addEventListener("DOMContentLoaded", async () => {
  const students = await getFailedStudents();
  renderStudents(students);
});
