% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 1.0
% date: 25/03/2010
% function: plotChain3D
% description:  Plot a chain 3D. 
%               input: chain
%               = number of chains
%               output: plot
function h=plotChain3D(chain,color)
p0=[0,0,0];
for i=1:size(chain,1)
    p = quaternionRotation(chain(i).v,chain(i).q);
    p1=p0+p;
%     h=plot3([p0(1),p1(1)],[p0(2),p1(2)],[p0(3),p1(3)],color);
    h=plot([p0(1),p1(1)],[p0(2),p1(2)],color);
    p0=p1;
    hold on;
end
hold off;
grid on;