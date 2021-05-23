CREATE TABLE knights_gwen (
  id INT NOT NULL AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL,
  Age INT NOT NULL

  PRIMARY KEY (id)
);

-- INSERT INTO knights
-- (Name, Age, Weapon)
-- VALUES
-- ("Sir Cumference", 30, "Great Sword");
-- INSERT INTO knights
-- (Name, Age, Weapon)
-- VALUES
-- ("Sir Prize", 19, "Javelin");

-- /*GETTING DATA FROM TABLES*/

-- SELECT {columns} FROM {table} WHERE {query}

-- /*GetAll*/

-- SELECT * FROM knights;

-- /*GetById*/

-- SELECT * FROM knights WHERE Age < 40;

-- /*EDIT/UPDATE*/

-- SELECT
--   name = "Sir Cumference"
-- WHERE id = 1;

-- /*DELETE*/

-- DELETE FROM knights WHERE id =2;

-- SELECT FROM knights;