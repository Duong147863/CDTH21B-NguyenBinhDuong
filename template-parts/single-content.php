<div class="container margin-top">
	<div class="single-blog-wrapper">
		<?php get_template_part('template-parts/single', 'title'); ?>
		<div class="blog-post">
			<div class="blog-front-image">
				<?php get_template_part('template-parts/single', 'meta'); ?>
				<div class="full-blog-content">
					<?php the_content(); ?>
				</div>
			</div>
		</div>
	</div>
</div>
