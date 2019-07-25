MVC 过滤器
1. Action过滤器（IActionFilter）：行为过滤器
2. Result过滤器（IResultFilter）：结果过滤器
3. Exception过滤器（IExceptionFilter）：异常过滤器
4. Authorization过滤器（IAuthorizationFilter）： 权限校验过滤器

   Action过滤器：在Action执行之前和执行之后调用。 <br />
   Result过滤器：在结果之前和之后调用。 <br />
   Exception过滤器：在发生异常时调用。 <br />
   Authorization过滤器：身份验证时调用。

过滤器作用：一般用于，记录日志、异常处理、身份验证、行为记录等。

Bolg 地址: https://blog.csdn.net/qq_36330228/article/details/95766103
