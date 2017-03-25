% Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 12/04/2010
% function: slerp
% description:  quaternion interpolation using slerp (spherical linear
% interpolation)
%               input: origin and destination quaternion, f= fraction 0..1
%               output: interpolated quaternion
function q=slerp(qOrigin,qDestination,f,epsilon)
lambda = quaternionInnerProduct(qOrigin,qDestination);
lambda = sum(lambda);
if (lambda<0)
    %the quaternions are pointing in opposite direction, so use the
    %equivalent alternative representation
    qDestination=qDestination.*(-1);
    lambda = -lambda;
end

% %calculate interpolation factors
% if (norm(1-lambda)< epsilon)
%     %quaternions are nearly parallel. -->linear interpolation
%     r=1-f;
%     s = f;
% else
%     %set interpolation quaternion
%     alpha = acos(lambda);
%     gamma = 1./sin(alpha);
%     r=sin((1-f)*alpha)*gamma;
%     s=sin(f*alpha)*gamma;
% end
% 
% %set interpolation quaternion
% s = r*qOrigin(1)+s*qDestination(1);
% x = r*qOrigin(2)+s*qDestination(2);
% y = r*qOrigin(3)+s*qDestination(3);
% z = r*qOrigin(4)+s*qDestination(4);

%linear because slerp no funciona.
s = qOrigin(1)+f*(qDestination(1)-qOrigin(1));
x = qOrigin(2)+f*(qDestination(2)-qOrigin(2));
y = qOrigin(3)+f*(qDestination(3)-qOrigin(3));
z = qOrigin(4)+f*(qDestination(4)-qOrigin(4));
q = quaternion(s,[x,y,z]);

%normalize result
q = quaternionNormalize(q);

%TODO: Valid for matrix