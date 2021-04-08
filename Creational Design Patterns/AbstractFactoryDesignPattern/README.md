<h1>Abstract Factory Design Pattern</h1>

<p>In simple word, the Abstract Factory is a super factory that creates other factories. This Factory is also called Factory of Factories.</p>
<p>These factories produces objects, which have a common theme.</p>

<br />

<h3><strong>Implementation</strong></h3>

<p>There is an abstract class as the super factory, which will have two methods. One for creating the desired factory, which is “static” and would have “if/else” or “switch” statement to return the desired factory. And the other is for passing the actual product, which is abstract and should be implemented by the sub-factories. </p>

<p>Each sub-factory implements this abstract method, often with “if/else” or “switch” statement, to create the concrete product and return it.</p>

<p>The client code should create an instance of super factory and pass an argument to get the concrete factory and another argument to get the concrete product.  </p>

<br />

<h3><strong>Example</strong></h3>

<p>There multiple UI elements such as button, text area, input elements and etc.</p>
<p>However, these elements can be produced with respect to the operating system, upon which the application should work.</p>
<p>Therefore, it makes sense to have a super factory, which returns a UI factory for the desired operating system, and then create the desired UIs from the returned factory.</p>

<br />

<h3><strong>Negative Point</strong></h3>
<p>By adding a new factory, the super factory code should also change.</p>

<br />

<h3><strong>Example used in the code</strong></h3>
<p>There are two UI elements, namely, button and text area. They can be created whether for Windows or for Mac OS.</p>