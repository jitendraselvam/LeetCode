# 101. Symmetric Tree

class TreeNode(object):
    def __init__(self, x):
        self.val = x
        self.left = None
        self.right = None

class Solution(object):
    def isSymmetric(self, root):
        """
        :type root: TreeNode
        :rtype: bool
        """
        
        if not root:
            return True
        return self.mirror(root.left, root.right)

    def mirror(self,left,right):
        if not left or not right:
            return True
        if right.val != left.val:
            return False
        return self.mirror(left.left,right.right) and self.mirror(left.right,right.left)