# katalyst-roman-numerals
Practice Kata https://www.codurance.com/katalyst/roman-numerals

## Tips
- Take small steps. You should always be able to go to a green state (with all tests passing) quickly.
- Stick to the red, green and refactor steps.
- Try not to refactor in the red. If you write a failing test that would need a big rewrite to pass, consider removing the test, refactoring in the green, and then writing the test again.
- As you progress through the problem, you should see your algorithm start to evolve. In other words, as the tests get more specific, the code gets more generic.
- Don't be afraid to let the code get a little bit messy - sometimes that's the best way to spot the next refactoring step.

## Articles
[The Transformation Priority Premise by Robert C. Martin](http://blog.cleancoder.com/uncle-bob/2013/05/27/TheTransformationPriorityPremise.html)

The Transformations:

- ({}–>nil) no code at all->code that employs nil
- (nil->constant)
- (constant->constant+) a simple constant to a more complex constant
- (constant->scalar) replacing a constant with a variable or an argument
- (statement->statements) adding more unconditional statements.
- (unconditional->if) splitting the execution path
- (scalar->array)
- (array->container)
- (statement->recursion)
- (if->while)
- (expression->function) replacing an expression with a function or algorithm
- (variable->assignment) replacing the value of a variable.
