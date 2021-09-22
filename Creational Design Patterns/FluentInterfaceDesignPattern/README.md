<h1>Fluent Interface Design Pattern</h1>

<p>The Fluent Interfaces and Method chaining are related to each other, or we can say that one is a concept and the other is its implementation.</p>
<p>The main objective of the Fluent Interface Design Pattern is to apply multiple properties (or methods) to an object by connecting them with dots <code>.</code> without having to re-specify the object name each time.</p>
<p>However, to achieve this, <strong>Method Chaining</strong> must be exploited.</p>
<p><strong>Method chaining</strong> is a common technique where each method returns an object, and all these methods can be chained together to form a single statement.</p>

<br />

<h3><strong>Implementation</strong></h3>

<p>After creating a class for the desired object, another class would be created, which mostly has the same name and the <strong>Fluent</strong> suffix.</p>
<p>The Fluent class has a private property, which holds an instance of the actual class.</p>
<p>It also contains methods, which will either set the properties or call the methods of the actual class object and then returns <code>this</code>.</p>
<p>Finally, it has a method named <code>build</code> to return the product object.</p>

<br />

<h3><strong>Example</strong></h3>

<p>The HTTP request processing pipeline is a good example. For instance, after checking the authentication in a request, it should be passed to the next step, e.g., in order to extract other values from the request.</p>

<br />

<h3><strong>Example used in the code</strong></h3>
<p>There would be an Employee object, the Fluent interface is used to set its properties step-by-step.</p>
