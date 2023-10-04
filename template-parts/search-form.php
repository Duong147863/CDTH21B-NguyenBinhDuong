<?php $unique_id = esc_attr( uniqid( 'search-form-' ) ); ?>

<form role="search" method="get" class="navigation" action="<?php echo esc_url( home_url( '/' ) ); ?>">
	<span class="pe-7s-close close-menu" id="close-button"></span>
	<div class="search-wrap js-ui-search">
		<input class="js-ui-text" id="<?php echo $unique_id; ?>" type="text" value="<?php echo get_search_query(); ?>" name="s" placeholder="<?php _e('Search Here...', 'oak'); ?>">
		<span class="eks js-ui-close"></span>
	</div>
</form>
