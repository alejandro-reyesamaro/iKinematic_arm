function a = angulo(p1, p2, antan)

if abs(p1.x - p2.x) < eps % cuidarme de la división por cero
    a = pi/2;    
else
    m = (p1.y - p2.y)/(p1.x - p2.x);
    a = atan(m);
end
a = a + (a < 0)*pi + (p1.y > p2.y)*pi;

if abs(p1.y - p2.y) < eps && p1.x > p2.x
    a = a + pi;
end

if(a ~= antan)
    while a <= antan
        a = a + pi;
    end
end
