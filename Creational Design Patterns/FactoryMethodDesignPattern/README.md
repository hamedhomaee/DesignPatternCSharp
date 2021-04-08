<h1>Factory Method Design Pattern</h1>

<p>According to Gang of Four Definition: “Define an interface for creating an object, but let the subclasses decide which class to instantiate”.</p>
<p>The Factory Method Design Pattern is used, when we need to create the object (i.e., instance of the Product class) without exposing the object creation logic to the client.</p>

<br />

<h3><strong>Implementation</strong></h3>

<p>First step is to create an abstract class or an interface, which mostly has "Factory" suffix in its name.</p>

<p>Then an abstract method should be created, which is responsible for creating the actual object.</p>

<p>Next, another method should be created, which is concrete and its task is to call the mentioned abstract method in order to get the actual object and then return it. By using this approach, it is also possible to add some logic common to all different factories.</p>

<p>Finally, concrete factory classes should be created. These classes extend or implement the above abstract class or interface, and specifically, they should implement the abstract method to return the desired object.</p>

<br />

<h3><strong>Example</strong></h3>

<p>A website, in which users can register and choose their subscription type.</p>
<p>According to the type the user chooses, the corresponding user object would be created at runtime.</p>

<br />

<h3><strong>Positive Point</strong></h3>
<p>Using this approach, there is no need to modify any class, but only a new class should be created, which extends the abstract class or the interface (open/close principle).</p>

<br />

<h3><strong>Example used in the code</strong></h3>
<p>There is an absctract method in the Factory abstract class. Ford and BMW factories are added as concrete classes, which implements the abstract method.</p>