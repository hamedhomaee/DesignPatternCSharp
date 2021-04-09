<h1>Builder Design Pattern</h1>

<p>The Builder Design Pattern builds a complex object using many simple objects and using a step-by-step approach.</p>
<p>The Process of constructing a complex object should be generic so that the same construction process can be used to create different representations of the same complex object.</p>

<br />

<h3><strong>Implementation</strong></h3>

<p>First step is to create the class for the desired object.</p>
<p>This class could contain any implementation for its properties and methods, which are common to all this type of objects, but builder-specific members should be implemented by the respective builder.</p>
<br />
<p>The builder class should be created as abstract and has the following parts:</p>

*	A protected property representing the product it creates. 
*	Any method or property that the product needs to implement as abstract. 
*	A public void method just for executing the instantiation of the product object and assigning it to the corresponding property of this builder class. 
*	A public method which will return this product. 

<br />

<p>There is also an optional class as the <strong>director</strong>. This class has only one public method that returns the product. This method definition accepts the abstract builder. Inside the method the following parts get executed:</p>

*	First, the method of the builder responsible for creating an instance of the product would be called. 
*	Then, other methods of the builder should be called with any desired order. 
*	Finally, the method of the builder class responsible for returning the product should be called. 

<br />

<h3><strong>Example</strong></h3>

<p>Suppose for creating a user there are some steps as:</p>

*	Giving an identity to the user.
*	Creating an object representing user authentication aspect.
*	Creating an object representing the roles the user has. 

<p>There are two builders, one for accounts, which are Google based and the other for Microsoft based. There is a director class, which moderates the order of builder methods execution.</p>

<br />

<h3><strong>Points to consider</strong></h3>

* It is correct to say that builder classes are responsible for setting the values of the product properties (and sometimes methods). 
* It is also possible to make the **Director** method as static. 

<br />

<h3><strong>Example used in the code</strong></h3>
<p>In this example the desired object to be created is <strong>User</strong>.</p>
<p>In order to create ther <strong>User</strong> object, first its authentication aspects and then its roles should be specified.</p>
<p>There are Google- and Microsoft builders, which have their own logic for instantiating a <strong>User</strong>.</p>