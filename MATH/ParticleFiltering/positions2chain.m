function chain = positions2chain(x, y)
% Se asume que la primera posicion es el (0,0)

x_ = 0;
y_ = 0;
chain = [];
n = max(size(x));
for i=2:n
    chain = [chain; x(i) - x_, y(i) - y_, 0]; 
    x_ = x(i);
    y_ = y(i);
end

end