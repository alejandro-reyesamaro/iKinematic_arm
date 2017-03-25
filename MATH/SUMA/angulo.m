function a = angulo(p1, p2)

if abs(p1.x - p2.x) < eps
    a = pi/2;
else
    m = (p1.y - p2.y)/(p1.x - p2.x);
    a = atan(m);
end
if a < 0
    a = pi/2 - a;
end
if p1.y > p2.y
    a = a + pi;
end